using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OrderForm
{
    public partial class Form2 : Form
    {
        OrderService OrderService;//存传进来的orderservice
        Order changeOrder;//存修改的订单
        bool isAdd = false;//判断是否是添加订单
        
        public Form2(OrderService orderService, int flag)
        {
            this.OrderService = orderService;
            
            InitializeComponent();

            //初始化每一列不可编辑
            for(int i = 0; i < 4; i++)
            { 
                newOrderDetailDgv.Columns[i].ReadOnly = true; 
            }
            
            //根据行为不同进行不同操作
            if(flag != -1)
            {
                this.Text = "修改订单";
                isAdd = false;
                //存取要修改的订单
                this.changeOrder = orderService.checkByOrderNum(flag).FirstOrDefault();
            }
            else
            {
                this.Text = "添加订单";
                //存取新建订单
                changeOrder = new Order();
                //添加第一条订单明细
                changeOrder.orderDetails.Add(new OrderDetail());
                isAdd = true;
            }
            //绑定数据源
            newOrderDetail.DataSource = this.changeOrder.orderDetails;
        }

        //form2载入时一些初始化操作
        private void Form2_Load(object sender, EventArgs e)
        {
            if (isAdd)
            {
                //添加订单时，第一行设置为可编辑
                newOrderDetailDgv.Rows[0].Cells[0].Selected = true;
                for (int i = 0; i < newOrderDetailDgv.Columns.Count; i++)
                {
                    newOrderDetailDgv.Rows[0].Cells[i].ReadOnly = false;
                }
            }
            else
            {
                //修改订单时，填入订单原信息
                this.Nametxt.Text = changeOrder.customerName;
                this.orderNumtxt.Text = changeOrder.OrderNum.ToString();
            }
        }

        //点击“添加明细”后实现的功能
        private void AddDetailBtn_Click(object sender, EventArgs e)
        {
            int nowRow = newOrderDetailDgv.CurrentRow.Index;//获取现在最大行号

            //若前一行未填写完成，则不允许添加新明细
            if (newOrderDetailDgv.Rows[nowRow].Cells[0].Value == null || 
                newOrderDetailDgv.Rows[nowRow].Cells[1].Value == null ||
                int.Parse(newOrderDetailDgv.Rows[nowRow].Cells[3].Value.ToString()) == 0)
            {
                MessageBox.Show("当前新建订单明细未填写完成", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int newRow = nowRow + 1;//新行行号

            //反复赋值数据源，防止出异常
            newOrderDetailDgv.DataSource = null;
            this.changeOrder.orderDetails.Add(new OrderDetail());
            newOrderDetailDgv.DataSource = newOrderDetail;

            //新创建的明细行可编辑
            for (int i = 0; i < 4; i++)
            {
                newOrderDetailDgv.Rows[newRow].Cells[i].ReadOnly = false;
            }
        }

        //点击“删除明细”后实现的功能
        private void DeleteDetailBtn_Click(object sender, EventArgs e)
        {
            int selectOrderDetail = -1;
            if (newOrderDetailDgv.CurrentRow != null)
            {
               selectOrderDetail = newOrderDetailDgv.CurrentRow.Index;
            }

            if (selectOrderDetail >= 0)
            {
                string store = (string)newOrderDetailDgv.Rows[selectOrderDetail].Cells[0].Value;
                string name = (string)newOrderDetailDgv.Rows[selectOrderDetail].Cells[1].Value;
                int price = int.Parse(newOrderDetailDgv.Rows[selectOrderDetail].Cells[2].Value.ToString());
                int num = int.Parse(newOrderDetailDgv.Rows[selectOrderDetail].Cells[3].Value.ToString());
                DataGridViewRow row = newOrderDetailDgv.Rows[selectOrderDetail];
                newOrderDetailDgv.Rows.Remove(row);//先删除界面上的行，否则会有索引越界异常
                this.changeOrder.orderDetails.RemoveAll(obj => obj.itemName == name && obj.itemStore == store
                                                        && obj.itemNum == num && obj.itemPrice == price);
            }
        }

        //点击“修改明细”后实现的功能
        private void ChangeDetailBtn_Click(object sender, EventArgs e)
        {
            int selectRow = newOrderDetailDgv.CurrentRow.Index;//获取选取的行
            //使选取的行可编辑
            for (int i = 0; i < newOrderDetailDgv.ColumnCount; i++)
            {
                newOrderDetailDgv.Rows[selectRow].Cells[i].ReadOnly = false;
            }
        }

        //点击“保存明细”后实现的功能
        private void SaveDetailBtn_Click(object sender, EventArgs e)
        {
            int selectRow = newOrderDetailDgv.CurrentRow.Index;//获取选取的行的行号

            //当前明细未填写完，不允许保存
            if (newOrderDetailDgv.Rows[selectRow].Cells[0].Value == null ||
                newOrderDetailDgv.Rows[selectRow].Cells[1].Value == null ||
                int.Parse(newOrderDetailDgv.Rows[selectRow].Cells[3].Value.ToString()) == 0)
            {
                MessageBox.Show("当前订单明细未填写完成", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //设置为只读（不再能编辑，除非选择并“修改明细”）
            for (int i = 0; i < newOrderDetailDgv.ColumnCount; i++)
            {
                newOrderDetailDgv.Rows[selectRow].Cells[i].ReadOnly = true;
            }
        }

        //点击“保存订单”后实现的功能
        private void SaveOrderBtn_Click(object sender, EventArgs e)
        {
            bool comp = true;

            //检测是否有未填写完成的订单明细
            for (int i = 0; i < newOrderDetailDgv.ColumnCount; i++)
            {
                if (i == 2) break;

                if(i==4)
                {
                    for (int j = 0; j < newOrderDetailDgv.RowCount; j++)
                    {
                        if (int.Parse(newOrderDetailDgv.Rows[j].Cells[i].Value.ToString()) == 0)
                        {
                            comp = false;
                            break;
                        }
                    }
                }

                for (int j = 0; j < newOrderDetailDgv.RowCount; j++)
                {
                    if(newOrderDetailDgv.Rows[j].Cells[i].Value == null)
                    {
                        comp = false;
                        break;
                    }
                }
            }

            //存在未填写完的明细不允许保存
            if(!comp)
            {
                MessageBox.Show("请将空商店名或空商品名或数量为0的明细填写完成后再保存", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int _number = changeOrder.OrderNum; 

            //检查订单号是否合法
            if (int.TryParse(this.orderNumtxt.Text, out int number))
            {
                changeOrder.OrderNum = number;
            }
            else
            {
                MessageBox.Show("订单号格式错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //检查客户名是否合法
            if(this.Nametxt.Text == "")
            {
                MessageBox.Show("客户名不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                changeOrder.customerName = this.Nametxt.Text;
            }
            
            //没有明细的订单默认删除
            if(changeOrder.orderDetails.Count==0)
            {
                OrderService.deleteOrder(changeOrder.OrderNum);
                this.Close();
                return;
            }

            //添加失败弹出错误窗口
            if (isAdd)
            {
                if (!OrderService.addOrder(changeOrder))
                {
                    MessageBox.Show("保存的订单的订单号已存在", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                OrderService.changeOrder(changeOrder.OrderNum, changeOrder);
            }

            this.Close();
        }

    }
}
