using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void btnChia_mang_Click(object sender, EventArgs e)
        {
            ds_Mang.Rows.Clear();
            string octetNet1 = "", octetNet2 = "", octetNet3 = "", octetNet4 = "";//các biến lưu trữ các octet mạng sau khi chia
            string octetfNet1 = "", octetfNet2 = "", octetfNet3 = "", octetfNet4 = "";//các biến lưu trữ các octet địa chỉ đầu tiên sau khi chia
            string octetlNet1 = "", octetlNet2 = "", octetlNet3 = "", octetlNet4 = "";//các biến lưu trữ đia chỉ cuối cùng sau khi chia
            string octetBC1 = "", octetBC2 = "", octetBC3 = "", octetBC4 = "";//các biến lưu trữ địa chỉ broadcast sau khi chia
            string netBitAdd = "";//biến lưu trữ địa chỉ mạng sau khi chia dưới dạng chuỗi bit
            string firstBitAdd = "";//biến lưu trữ địa chỉ đầu tiên sau khi chia dưới dạng chuỗi bit
            string lastBitAdd = "";//biến lưu trữ địa chỉ cuối cùng sau khi chia dưới dạng chuỗi bit
            string BC_Bit_Add = "";//biến lưu trữ địa chỉ broadcast sau khi chia dưới dạng chuỗi bit
            int bitCount = 0;//biến đếm các bit
            string newHostBit = "";//biến lưu trữ bit phần host mới
            string newNetBit = "";//biến lưu trữ bit phần mạng mới
            string bNet_IP = "";//biến lưu trữ địa chỉ mạng dưới dạng bit
            double jump = 0;//biến lưu trữ bước nhảy
            double hostNum = 0;//biến lưu trữ số lượng host
            double remaining = 0;//tạo biến lưu trữ các bit còn lại sau khi mượn
            double borrow = 0;//tạo biến lưu trữ bit mượn
            string prefix = "";//tạo chuỗi lưu trữ chuỗi số prefix khi người dùng nhập vào 
            int iPrefix;//biến lưu trữ prefix
            string strSubnet_Num = "";//tạo chuỗi lưu trữ chuỗi số mạng con cần chia
            double subnetNum = 0;//tạo biến lưu trữ số mang con cần chia
            int count = 0;//biến đếm số lần lặp
            string OctAdd1 = "", OctAdd2 = "", OctAdd3 = "", OctAdd4 = "";//chuỗi lưu trữ các chuỗi octet của địa chỉ mạng
            byte bOctAdd1, bOctAdd2, bOctAdd3, bOctAdd4;//biến lưu trữ các octet của địa chỉ mạng kiểu byte
            int check = 0;//biến đếm kiểm tra dữ liệu nhập vào
            int dotCount = 0;//biến kiểm tra số lượng octet
            int slassCount = 0;//biến kiểm tra số lượng dấu "/"

            //kiểm tra dữ liệu nhập vào
            for(int i=0; i<txt_NetIP.Text.Length; i++)
            {
                if ((txt_NetIP.Text[i] < 46 || txt_NetIP.Text[i] > 57))
                {
                    check++;
                }
                if (txt_NetIP.Text[i] == '.')
                {
                    if (txt_NetIP.Text[txt_NetIP.Text.Length-1] == '.')
                    {
                        break;
                    }
                    else if (txt_NetIP.Text[i + 1] < 48 || txt_NetIP.Text[i + 1] > 57)
                        check++;
                    dotCount++;
                }
                if (txt_NetIP.Text[i] == '/')
                {
                    if (txt_NetIP.Text[txt_NetIP.Text.Length - 1] == '/')
                    {
                        break;
                    }
                    else if (txt_NetIP.Text[i + 1] < 48 || txt_NetIP.Text[i + 1] > 57)
                        check++;
                    slassCount++;
                }
            }
            for(int i=0; i<txtNum.Text.Length; i++)
            {
                if (txtNum.Text[i] < 48 || txtNum.Text[i] > 57)
                    check++;
            }    
            if(check != 0 || dotCount != 3  || slassCount != 1) 
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtNum.Text == "" || txt_NetIP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //vòng lặp lưu trữ các octet và số prefix
                while (count < txt_NetIP.Text.Length)
                {
                    while (txt_NetIP.Text[count] != '.')
                    {
                        OctAdd1 += txt_NetIP.Text[count];
                        count++;
                    }
                    count++;
                    while (txt_NetIP.Text[count] != '.')
                    {
                        OctAdd2 += txt_NetIP.Text[count];
                        count++;
                    }
                    count++;
                    while (txt_NetIP.Text[count] != '.')
                    {
                        OctAdd3 += txt_NetIP.Text[count];
                        count++;
                    }
                    count++;
                    while (txt_NetIP.Text[count] != '/')
                    {
                        OctAdd4 += txt_NetIP.Text[count];
                        count++;
                    }
                    count++;
                    while (count < txt_NetIP.Text.Length)
                    {
                        prefix += txt_NetIP.Text[count];
                        count++;
                    }
                }

                //vòng lặp lưu trữ số mạng con
                for (int i = 0; i < txtNum.Text.Length; i++)
                {
                    strSubnet_Num += txtNum.Text[i];
                }

                //ép kiểu dữ liệu
                bOctAdd1 = byte.Parse(OctAdd1);
                bOctAdd2 = byte.Parse(OctAdd2);
                bOctAdd3 = byte.Parse(OctAdd3);
                bOctAdd4 = byte.Parse(OctAdd4);
                iPrefix = int.Parse(prefix);
                subnetNum = double.Parse(strSubnet_Num);
                if (iPrefix > 32 || iPrefix < 8)
                    MessageBox.Show("Số prefix không hợp lệ. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (subnetNum >= Math.Pow(2, 32 - iPrefix + 1))
                    MessageBox.Show("Số lượng mạng con quá lớn. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    //tính toán số liệu
                    borrow = (long)Math.Log(subnetNum, 2);
                    byte[] byteAddress = new byte[4] { bOctAdd4, bOctAdd3, bOctAdd2, bOctAdd1 };
                    BitArray bitAdd = new BitArray(byteAddress);
                    remaining = 32 - borrow - iPrefix;
                    hostNum = Math.Pow(2, remaining) - 2;
                    jump = Math.Pow(2, 8 - borrow);

                    //chuyển đổi địa chỉ mạng thành chuỗi bit
                    for (int j = bitAdd.Length - 1; j >= 0; j--)
                    {
                        bNet_IP += (Convert.ToInt32(bitAdd[j]).ToString());
                    }
                    //chia mạng, lưu phần network bit mới
                    for (int i = bitCount; i < iPrefix + borrow; i++)
                    {
                        bitCount++;
                        newNetBit += bNet_IP[i];
                    }
                    //chia mạng, lưu phần host bit mới
                    for (int i = bitCount; i < 32; i++)
                    {
                        newHostBit += bNet_IP[i];
                    }
                    //lưu địa chỉ mạng
                    for (int i = 0; i < newNetBit.Length; i++)
                    {
                        netBitAdd += newNetBit[i];
                    }
                    for (int i = bitCount; i < 32; i++)
                    {
                        netBitAdd += "0";
                    }
                    //lưu địa chỉ broadcast
                    for (int i = 0; i < newNetBit.Length; i++)
                    {
                        BC_Bit_Add += newNetBit[i];
                    }
                    for (int i = bitCount; i < 32; i++)
                    {
                        BC_Bit_Add += "1";
                    }
                    //lưu địa chỉ đầu
                    for (int i = 0; i < 31; i++)
                    {
                        firstBitAdd += netBitAdd[i];
                    }
                    firstBitAdd += "1";
                    //lưu địa chỉ cuối
                    for (int i = 0; i < 31; i++)
                    {
                        lastBitAdd += BC_Bit_Add[i];
                    }
                    lastBitAdd += "0";
                    //chuyển chuỗi bit network thành các octet
                    for (int i = 0; i < 8; i++)
                    {
                        octetNet1 += netBitAdd[i];
                    }
                    for (int i = 8; i < 16; i++)
                    {
                        octetNet2 += netBitAdd[i];
                    }
                    for (int i = 16; i < 24; i++)
                    {
                        octetNet3 += netBitAdd[i];
                    }
                    for (int i = 24; i < 32; i++)
                    {
                        octetNet4 += netBitAdd[i];
                    }
                    //chuyển đổi chuỗi bit địa chỉ mạng đầu thành các octet
                    for (int i = 0; i < 8; i++)
                    {
                        octetfNet1 += firstBitAdd[i];
                    }
                    for (int i = 8; i < 16; i++)
                    {
                        octetfNet2 += firstBitAdd[i];
                    }
                    for (int i = 16; i < 24; i++)
                    {
                        octetfNet3 += firstBitAdd[i];
                    }
                    for (int i = 24; i < 32; i++)
                    {
                        octetfNet4 += firstBitAdd[i];
                    }
                    //chuyển đổi chuỗi bit địa chỉ mạng cuối thành các octet
                    for (int i = 0; i < 8; i++)
                    {
                        octetlNet1 += lastBitAdd[i];
                    }
                    for (int i = 8; i < 16; i++)
                    {
                        octetlNet2 += lastBitAdd[i];
                    }
                    for (int i = 16; i < 24; i++)
                    {
                        octetlNet3 += lastBitAdd[i];
                    }
                    for (int i = 24; i < 32; i++)
                    {
                        octetlNet4 += lastBitAdd[i];
                    }
                    //chuyển đổi chuỗi bit địa chỉ broadcast thành các octet
                    for (int i = 0; i < 8; i++)
                    {
                        octetBC1 += BC_Bit_Add[i];
                    }
                    for (int i = 8; i < 16; i++)
                    {
                        octetBC2 += BC_Bit_Add[i];
                    }
                    for (int i = 16; i < 24; i++)
                    {
                        octetBC3 += BC_Bit_Add[i];
                    }
                    for (int i = 24; i < 32; i++)
                    {
                        octetBC4 += BC_Bit_Add[i];
                    }
                    //in danh sách các mạng con
                    if (iPrefix >= 8 && iPrefix < 16)
                    {
                        for (int i = 0; i < subnetNum; i++)
                        {
                            ds_Mang.Rows.Add((i + 1).ToString(), Convert.ToInt32(octetNet1, 2) + "." + (Convert.ToInt32(octetNet2, 2) + jump * i) + "." + Convert.ToInt32(octetNet3, 2) + "." + Convert.ToInt32(octetNet4, 2), Convert.ToInt32(octetfNet1, 2) + "." + (Convert.ToInt32(octetfNet2, 2) + jump * i) + "." + Convert.ToInt32(octetfNet3, 2) + "." + Convert.ToInt32(octetfNet4, 2), Convert.ToInt32(octetlNet1, 2) + "." + (Convert.ToInt32(octetlNet2, 2) + jump * i) + "." + Convert.ToInt32(octetlNet3, 2) + "." + Convert.ToInt32(octetlNet4, 2), Convert.ToInt32(octetBC1, 2) + "." + (Convert.ToInt32(octetBC2, 2) + jump * i) + "." + Convert.ToInt32(octetBC3, 2) + "." + Convert.ToInt32(octetBC4, 2));
                        }
                    }
                    else if (iPrefix >= 16 && iPrefix < 24)
                    {
                        for (int i = 0; i < subnetNum; i++)
                        {
                            ds_Mang.Rows.Add((i + 1).ToString(), Convert.ToInt32(octetNet1, 2) + "." + Convert.ToInt32(octetNet2, 2) + "." + (Convert.ToInt32(octetNet3, 2) + jump * i) + "." + Convert.ToInt32(octetNet4, 2), Convert.ToInt32(octetfNet1, 2) + "." + Convert.ToInt32(octetfNet2, 2) + "." + (Convert.ToInt32(octetfNet3, 2) + jump * i) + "." + Convert.ToInt32(octetfNet4, 2), Convert.ToInt32(octetlNet1, 2) + "." + Convert.ToInt32(octetlNet2, 2) + "." + (Convert.ToInt32(octetlNet3, 2) + jump * i) + "." + Convert.ToInt32(octetlNet4, 2), Convert.ToInt32(octetBC1, 2) + "." + Convert.ToInt32(octetBC2, 2) + "." + (Convert.ToInt32(octetBC3, 2) + jump * i) + "." + Convert.ToInt32(octetBC4, 2));
                        }
                    }
                    else if (iPrefix >= 24 && iPrefix < 30)
                    {
                        for (int i = 0; i < subnetNum; i++)
                        {
                            ds_Mang.Rows.Add((i + 1).ToString(), Convert.ToInt32(octetNet1, 2) + "." + Convert.ToInt32(octetNet2, 2) + "." + Convert.ToInt32(octetNet3, 2) + "." + (Convert.ToInt32(octetNet4, 2) + jump * i), Convert.ToInt32(octetfNet1, 2) + "." + Convert.ToInt32(octetfNet2, 2) + "." + Convert.ToInt32(octetfNet3, 2) + "." + (Convert.ToInt32(octetfNet4, 2) + jump * i), Convert.ToInt32(octetlNet1, 2) + "." + Convert.ToInt32(octetlNet2, 2) + "." + Convert.ToInt32(octetlNet3, 2) + "." + (Convert.ToInt32(octetlNet4, 2) + jump * i), Convert.ToInt32(octetBC1, 2) + "." + Convert.ToInt32(octetBC2, 2) + "." + Convert.ToInt32(octetBC3, 2) + "." + (Convert.ToInt32(octetBC4, 2) + jump * i));
                        }
                    }
                }
            }    
        }
    }
}
