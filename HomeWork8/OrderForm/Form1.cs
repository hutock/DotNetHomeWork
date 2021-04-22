using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Sale;

namespace OrderForm
{
    public partial class Form1 : Form
    {

        OrderService orderService = new OrderService();//订单管理对象
        List<Order> queryOrder = new List<Order>();//查询出来的订单

        public Form1()
        {
            InitializeComponent();
        }


        //点击“查看订单详情”后实现的功能
        private void queryDetail_Click(object sender, EventArgs e)
        {
            int selectOrder = -1;//订单Dgv选取的订单所在行号
            if(orderDataGridView.CurrentRow!=null)
            {
                selectOrder = orderDataGridView.CurrentRow.Index;
                //当未选取行时不为其赋值
            }

            //选取行后行号必为非负
            if(selectOrder>=0)
            {
                //获取订单号（第一列）
                int number = int.Parse(orderDataGridView.Rows[selectOrder].Cells[0].Value.ToString());
                //查询到对应订单，并把对应订单明细作为数据源
                OrderDetails.DataSource = orderService.orders.Find(obj => obj.orderNum == number).orderDetails;
                
            }
            
        }


        //控制选择查询方法时，输入框的显示问题（查询所有订单不需要输入）
        private void queryTypeCombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (queryTypeCombox.SelectedIndex != 0)
            {
                queryStrlab.Visible = true;
                queryStrtextBox.Visible = true;
            }
            else
            {
                queryStrlab.Visible = false;
                queryStrtextBox.Visible = false;
            }
        }


        //点击“查询”按钮时实现的功能
        private void queryBtn_Click(object sender, EventArgs e)
        {
            //获取选取的查询方法（通过combox的index）
            int C_selectIndex = queryTypeCombox.SelectedIndex;
            //获取textbox输入的字符串
            string info = queryStrtextBox.Text;

            //不同的方法采用不同的查询函数
            switch (C_selectIndex)
            {
                //查询所有订单
                case 0:
                    queryOrder = orderService.checkAllOrders();
                    break;
                //根据订单号查询（包括输入非法时弹出提示窗）
                case 1:
                    if(!int.TryParse(info, out int number))
                    {
                        MessageBox.Show("非法输入，订单号应为整数！", "错误", MessageBoxButtons.OK,MessageBoxIcon.Error);
                        break;
                    }
                    queryOrder = orderService.checkByOrderNum(number);
                    break;
                //根据客户名字查询
                case 2:
                    queryOrder = orderService.checkByCustomerName(info);
                    break;
                //根据商品名字查询
                case 3:
                    queryOrder = orderService.checkByItemName(info);
                    break;
                //根据总价查询（包括输入非法时弹出提示窗）
                case 4:
                    if (!int.TryParse(info, out int sum))
                    {
                        MessageBox.Show("非法输入，总价应为整数！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    queryOrder = orderService.checkBySum(sum);
                    break;
                default:
                    return;
            }

            if (queryOrder.Any())
            {
                //当查询到存在订单时修改数据源进行显示
                Orders.DataSource = queryOrder;
                orderDetailDataGridView.DataSource = null;
            }
            else
            {
                //没查询到弹出错误窗口
                if (C_selectIndex != 0)
                    MessageBox.Show("没有找到相关订单，请检查输入信息是否正确", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        //想要退出时弹出确定警告
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("确定要退出？","警告",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                this.Dispose();
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }


        //点击“删除订单”按钮时实现的功能
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int selectOrder = -1;//订单Dgv选取的订单所在行号
            if (orderDataGridView.CurrentRow != null)
            {
                selectOrder = orderDataGridView.CurrentRow.Index;
                //当未选取行时不为其赋值
            }

            //选取行后行号必为非负
            if (selectOrder >= 0)
            {
                //获取订单号（第一列）
                int number = int.Parse(orderDataGridView.Rows[selectOrder].Cells[0].Value.ToString());
                orderDetailDataGridView.DataSource = null;//删除订单可能是显示订单明细的订单
                orderDataGridView.DataSource = null;//先设置为null，防止出现异常 /滑稽
                orderService.deleteOrder(number);//删除该订单数据
                queryOrder.RemoveAll(obj => obj.orderNum == number);//删除界面绑定数据源的订单
                orderDataGridView.DataSource = Orders;//复原数据源绑定
            }
        }


        //点击“添加订单”按钮时实现的功能
        private void Addbtn_Click(object sender, EventArgs e)
        {
            //创建form窗口，向其中传入orderservice和订单号参数（用于修改订单，添加订单传-1用于区分）
            Form2 addForm = new Form2(orderService, -1);
            addForm.ShowDialog();//显示窗口form2

            resetForm1();//form2关闭后，因为来了新数据，重置下显示
        }

        //点击“修改订单”按钮时实现的功能
        private void changeBtn_Click(object sender, EventArgs e)
        {
            //获取选取的订单行号
            int selectRow = orderDataGridView.CurrentRow.Index;
            //获取选取订单号
            int number = int.Parse(orderDataGridView.Rows[selectRow].Cells[0].Value.ToString());
            Form2 changeForm = new Form2(orderService, number);//传入参数
            changeForm.ShowDialog();//显示窗口form2

            resetForm1();//form2关闭后，因为来了新数据，重置下显示
        }

        //重置显示函数
        private void resetForm1()
        {
            queryOrder = orderService.checkAllOrders();
            Orders.DataSource = queryOrder;

            queryTypeCombox.SelectedIndex = 0;
            queryStrtextBox.Text = "";
            queryStrlab.Visible = false;
            queryStrtextBox.Visible = false;
        }

        //点击“导入订单”按钮时实现的功能
        private void ImportBtn_Click(object sender, EventArgs e)
        {
            ImportOrdersODLG.ShowDialog();//显示选择文件对话框
            string filename = ImportOrdersODLG.FileName;//存文件名
            orderService.Import(filename);//调用orderservice的导入函数

            //重置显示界面
            queryOrder = orderService.checkAllOrders();
            Orders.DataSource = queryOrder;
        }

        //点击“导出订单”按钮时实现的功能
        private void ExportBtn_Click(object sender, EventArgs e)
        {
            ExportOrdersSDLG.ShowDialog();//显示保存文件对话框
            string filename = ExportOrdersSDLG.FileName;//存文件名
            orderService.Export(filename);//调用orderservice的导出函数
        }

        //form1第一次调用时初始化
        private void Form1_Shown(object sender, EventArgs e)
        {
            queryTypeCombox.SelectedIndex = 0;

            queryStrlab.Visible = false;
            queryStrtextBox.Visible = false;

            queryOrder = orderService.checkAllOrders();
            Orders.DataSource = queryOrder;
            orderDetailDataGridView.DataSource = OrderDetails;
        }
    }
}
