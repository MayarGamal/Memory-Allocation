using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Allocation_Segmentation
{
    public partial class Memory : Form
    {
        /////////////////////////////
        public int Total_size;
        public List<Segment> MEMORY;

        public List<Segment> Sorted_Holes = new List<Segment>();

        public int start_hole;
        public int size_hole;
        public int count_hole ;
        public int count = 0;
        public int start = 0;
        public int end;
        public string type;
        public int old_process_count = 0;
        public int Number_seg;
        public string Name_seg;
        public int size_seg;
        public int process_count = 1;
        public int segment_count = 0;
        public int txtBox_count = 0;
        public int Label_count = 0;
        public int hole_count;

        public List<Segment> sorted_Memory;

        public Memory()
        {
            InitializeComponent();
            MEMORY = new List<Segment>();
        }

        public void Memory_size_KeyDown(object sender, KeyEventArgs e)
        {
            int valid;
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(Memory_size.Text, out valid))
                {
                    Total_size = int.Parse(Memory_size.Text);
                    Memory_size.Enabled = false;
                }        
                else
                    MessageBox.Show("Please Enter The Correct Number of Total Memory Size");
            }
        }

        private void No_hole_KeyDown(object sender, KeyEventArgs e)
        {
            int valid;
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(No_hole.Text, out valid))
                {
                    count_hole = int.Parse(No_hole.Text);
                    No_hole.Enabled = false;
                }
                else
                    MessageBox.Show("Please Enter The Correct Number of Holes");
            }
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            int valid;
            if (MEMORY.Count == 0)
            {
                if  (int.TryParse(Memory_size.Text, out valid ))
                {
                    Total_size = int.Parse(Memory_size.Text);
                    Memory_size.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Please Enter The Correct Number of Total Memory Size");
                    return;
                }

                if (int.TryParse(No_hole.Text, out valid))
                {
                    count_hole = int.Parse(No_hole.Text);
                    No_hole.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Please Enter The Correct Number Of Holes");
                    return;
                }
                if (count_hole == 0)
                {
                    MEMORY.Add(new Segment("Old Process0", 0, Total_size));
                    Segments_box.Enabled = false;
                    Deallocate_box.Items.Add("Old Process" + old_process_count);
                    old_process_count++;
                    return;
                }
            }
            if (int.TryParse(starting_add.Text, out valid))
            {
                start_hole = int.Parse(starting_add.Text);
                starting_add.Clear();
            }
            else
            {
                MessageBox.Show("Please Enter The Correct Number Of Hole Starting Adress");
                return;
            }

            if (int.TryParse(Hole_size.Text, out valid))
            {
                size_hole = int.Parse(Hole_size.Text);
                Hole_size.Clear();
            }
            else
            {
                MessageBox.Show("Please Enter The Correct Number Of Hole Size");
                return;
            }

            allocate_Holes();

            if( count == count_hole )
            {
                Holes_box.Enabled = false;
                allocate_oldProcesses();
            }
        }

        public void allocate_Holes ()
        {
            //fe point enna ned5aal el holes 3'alat aslun ==> fe nafs makan hole 2adema ??
            if ((start_hole + size_hole) <= Total_size  )
            {
                if ( MEMORY.Count == 0 )
                {
                    MEMORY.Add(new Segment("Hole", start_hole, size_hole));
                    count++;
                }
                else  
                {
                    if (MEMORY[count -1].Start_add == start_hole)
                    {
                        if (MEMORY[count - 1].end >= (start_hole + size_hole))
                            count_hole--;
                        else
                        {
                            MEMORY[count - 1].Size = size_hole;
                            count_hole--;
                        }
                    }
                    else if (MEMORY[count - 1].Start_add > start_hole)
                    {
                        if (MEMORY[count -1].Start_add > (start_hole + size_hole))
                        {
                            MEMORY.Add(new Segment("Hole", start_hole, size_hole));
                            count++;
                        }
                        else if (MEMORY[count - 1].Start_add == (start_hole + size_hole))
                        {
                            MEMORY[count - 1].Start_add = start_hole;
                            MEMORY[count - 1].Size += size_hole;
                            count_hole--;
                        }
                        else if (MEMORY[count - 1].end >= (start_hole + size_hole))
                        {

                            MEMORY[count - 1].Size = MEMORY[count - 1].end - start_hole;
                            MEMORY[count - 1].Start_add = start_hole;
                            count_hole--;
                        }
                        else
                        {
                            MEMORY[count - 1].Size =  size_hole;
                            MEMORY[count - 1].Start_add = start_hole;
                            count_hole--;
                        }
                    }
                    else if (MEMORY[count - 1].Start_add < start_hole)
                    {
                        if (MEMORY[count - 1].end < start_hole)
                        {
                            MEMORY.Add(new Segment("Hole", start_hole, size_hole));
                            count++;
                        }
                        else if (MEMORY[count - 1].end >= (start_hole + size_hole))
                        {
                            count_hole--;
                        }
                        else
                        {
                            MEMORY[count - 1].Size = MEMORY[count - 1].Size +
                                          ((size_hole + start_hole) - MEMORY[count - 1].end);
                            count_hole--;
                        }
                    }
                   /* if ( MEMORY[count-1].end == start_hole )
                    {
                        MEMORY[count-1].Size = MEMORY[count-1].Size + size_hole;
                        count_hole--;
                    }
                    else if (MEMORY[count - 1].end > start_hole && 
                             MEMORY[count - 1].Start_add < start_hole  || 
                             )
                    {
                        
                        MEMORY[count - 1].Size = MEMORY[count - 1].Size 
                            +( (start_hole +size_hole) -  MEMORY[count - 1].end  ) ;
                        count_hole--;
                      
                    }
                    else if (MEMORY[count - 1].Start_add == start_hole
                                 && MEMORY[count-1].Size == size_hole)
                    {
                        count_hole--;
                    }
                    else
                    {
                        MEMORY.Add(new Segment("Hole", start_hole, size_hole));
                        count++;
                       
                    }*/
                }
            }
            else
            {
                MessageBox.Show("wrong entering for Hole!");//warning !!!!
            }
        }

        public void allocate_oldProcesses()
        {
            MEMORY = MEMORY.OrderBy(X => X.Start_add).ToList();//sort holes 
            int BeforeSegIndx;
            int AfterSegIndex;
            int i = 0;

            if (MEMORY[0].Start_add != 0)//hole not in 0
            {
                MEMORY.Add(new Segment("Old Process" + old_process_count, 0, MEMORY[0].Start_add ) );
                Deallocate_box.Items.Add("Old Process" + old_process_count );
                old_process_count++;
            }

            

            for ( i =0 ; i < count - 1 ; i++)   //insert old process inside
            {
                BeforeSegIndx = MEMORY[i].end ;
                AfterSegIndex = MEMORY[i + 1].Start_add - BeforeSegIndx;
                MEMORY.Add(new Segment("Old Process" + old_process_count
                                            , BeforeSegIndx, AfterSegIndex));
                Deallocate_box.Items.Add("Old Process" + old_process_count);
                old_process_count++;
            }

            if (MEMORY[count - 1].end != Total_size)//hole not in last 
            {
                BeforeSegIndx = MEMORY[count - 1].end;
                AfterSegIndex = Total_size - BeforeSegIndx;
                MEMORY.Add(new Segment("Old Process" + old_process_count
                                            , BeforeSegIndx, AfterSegIndex));
                Deallocate_box.Items.Add("Old Process" + old_process_count);
                old_process_count++;
            }

            MEMORY = MEMORY.OrderBy(X => X.Start_add).ToList();
        }

        public void Generate_btn_Click(object sender, EventArgs e)//draw
        {
            if(MEMORY.Count == 0 )
            {
                MessageBox.Show("Please enter Holes first");
                return;
            }
            Clear_btn_Click(Clear_btn , e );

            hole_count = 0;

           // for (int j = 0; j < MEMORY.Count; j++)
             //   MessageBox.Show(MEMORY[j].Name);

            TextBox myText = new TextBox();
             myText.Location = new Point( 500 , 140 );

            if (MEMORY[0].Name == "Hole")
            {
                myText.Text = "Hole" + hole_count;
                myText.BackColor = Color.Green;
                hole_count++;
            }
            else
            {
                myText.Text = MEMORY[0].Name;
                myText.BackColor = Color.Red;
            }

            myText.Multiline = true;
             myText.Height = MEMORY[0].Size + 20 ;
             myText.Name = "myText";
            myText.TextAlign = HorizontalAlignment.Center;
           // myText.Top = (this.Height - myText.Height) / 2;
            this.Controls.Add(myText);
            

txtBox_count++;

             Label mylabel = new Label();
             mylabel.Location = new Point( 450 , 140  );
             mylabel.Text = MEMORY[0].Start_add.ToString() ;
            mylabel.Name = "mylabel";
            this.Controls.Add(mylabel);
            Label_count++;

            int save_heighet = 138  ;

            for(int i = 1 ; i < MEMORY.Count ; i++)
            {
                save_heighet += MEMORY[i - 1].Size + 20 ;
            
                TextBox myText1 = new TextBox();
                myText1.Location = new Point( 500 , save_heighet + 3 );

                if (MEMORY[i].Name == "Hole")
                {
                    myText1.Text = "Hole" + hole_count;
                    myText1.BackColor = Color.Green;
                    hole_count++;
                }
                else
                {
                    myText1.Text = MEMORY[i].Name;
                    myText1.BackColor = Color.Red;
                }
               


                myText1.Multiline = true;
                myText1.Height = MEMORY[i].Size + 20 ;
                myText1.Name = "myText1";
                myText1.TextAlign = HorizontalAlignment.Center;
               // myText1.Top = (this.Height - myText1.Height) / 2;


                this.Controls.Add(myText1);
                txtBox_count++;

                Label mylabel1 = new Label();
                mylabel1.Location = new Point( 450 , save_heighet + 3 );
                mylabel1.Text = ( MEMORY[i].Start_add ).ToString();
                mylabel1.Name = "mylabel1";
                this.Controls.Add(mylabel1);
                Label_count++;

            }

            save_heighet += MEMORY[ MEMORY.Count - 1 ].Size + 25;

            Label mylabel2 = new Label();
            mylabel2.Location = new Point(450, save_heighet - 10 );
            mylabel2.Text = Total_size.ToString();
            mylabel2.Name = "mylabel1";
            this.Controls.Add(mylabel2);
            Label_count++;

        }

        private void No_seg_KeyDown(object sender, KeyEventArgs e)
        {
            int valid;
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(No_seg.Text, out valid))
                {
                    Number_seg = int.Parse(No_seg.Text);
                    No_seg.Enabled = false;
                }
                else
                    MessageBox.Show("Please Enter The Correct Number of Segments");
            }
        }

        private void Submit_btn2_Click(object sender, EventArgs e)
        {
            int valid;
            if (Allocation_list.SelectedItem == null)
            {
                MessageBox.Show("Please Choose Method Of Allocation");
                return;
            }

            if ( MEMORY.Find(X => X.Name == "Hole") == null)
            {
                MessageBox.Show(" Memory is Busy , There's no Holes");
                No_seg.Clear();
                Seg_name.Clear();
                Seg_size.Clear();
                return;
            }

            if (int.TryParse(No_seg.Text, out valid))
            {
                Number_seg = int.Parse(No_seg.Text);
                No_seg.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please Enter The Correct Number of Segments");
                return;
            }

            if (Seg_name.Text == "")
            {
                MessageBox.Show("please enter Segment Name");
                return;
            }
            else
            {
                Name_seg = Seg_name.Text;
                Seg_name.Clear();
            }

            if (int.TryParse(Seg_size.Text, out valid))
            {
                size_seg = int.Parse(Seg_size.Text);
                Seg_size.Clear();
            }
            else
            {
                MessageBox.Show("Please Enter The Correct Number Of Segment Size");
                return;
            }
            allocate_segment();
             if (segment_count == 0)
            {
                No_seg.Clear();
                Segments_box.Enabled = false;
                return;
            }

            if ( segment_count == Number_seg )
            {
                Segments_box.Enabled = false;
                Deallocate_box.Items.Add("P" + process_count);
                segment_count = 0;
                process_count++;
            }
        }

        public void allocate_segment()
        {
            if (Allocation_list.SelectedIndex == 0)
                first_fit();
            else if (Allocation_list.SelectedIndex == 1)
                Best_fit();
            else if (Allocation_list.SelectedIndex == 2)
                Worst_fit();
        }

        public void first_fit()
        {
            int i;
            for( i =0; i < MEMORY.Count   ;i++)
            {
                if (MEMORY[i].Name == "Hole")
                {
                    if (MEMORY[i].Size == size_seg)
                    {
                        MEMORY[i].Name = "P" + process_count + ":" + Name_seg;
                        segment_count++;
                        return;
                    }
                    else if ( MEMORY[i].Size > size_seg)
                    {
                        MEMORY.Add(new Segment("P" + process_count + ":" + Name_seg
                                       , MEMORY[i].Start_add, size_seg ));

                        //new hole
                        MEMORY[i].Start_add = MEMORY[i].Start_add + size_seg;
                        MEMORY[i].Size = MEMORY[i].Size - size_seg;

                        MEMORY = MEMORY.OrderBy(X => X.Start_add).ToList();
                        segment_count++;
                        return;
                    }
                }
            }
            if (i == MEMORY.Count)
            {
                MessageBox.Show("Process doesn't fit");
                deallocate("P" + process_count);
                segment_count = 0;
            }

        }

        public void Best_fit()
        {
            if (Sorted_Holes.Count != 0)
                Sorted_Holes.RemoveRange(0, Sorted_Holes.Count);

            int i;
            for (i = 0; i < MEMORY.Count; i++)
            {
                if (MEMORY[i].Name == "Hole")
                {
                    // hna5od el Holes n7otaha f List Sorted_Holes b3den n3mlha sort by size
                    Sorted_Holes.Add(new Segment("Hole", MEMORY[i].Start_add , MEMORY[i].Size));           
                }
            }

            Sorted_Holes = Sorted_Holes.OrderBy(X => X.Size).ToList();

            int j;
            for (j = 0; j < Sorted_Holes.Count; j++)
            {
                if (Sorted_Holes[j].Size == size_seg)
                {
                    Sorted_Holes[j].Name = "P" + process_count + ":" + Name_seg;
                    segment_count++;
                    break;
                }
                else if (Sorted_Holes[j].Size > size_seg)
                {
                    Sorted_Holes.Add(new Segment("P" + process_count + ":" + Name_seg
                                   , Sorted_Holes[j].Start_add, size_seg ));
                    //new hole
                    Sorted_Holes[j].Start_add = Sorted_Holes[j].Start_add + size_seg;
                    Sorted_Holes[j].Size = Sorted_Holes[j].Size - size_seg;

                    Sorted_Holes = Sorted_Holes.OrderBy(X => X.Start_add).ToList();///
                    segment_count++;
                    break;
                }
            }
            

            MEMORY.RemoveAll(p => p.Name == "Hole");
           
            for (int k = 0; k < Sorted_Holes.Count; k++)
            {
                MEMORY.Add(new Segment(  Sorted_Holes[k].Name
                    , Sorted_Holes[k].Start_add, Sorted_Holes[k].Size));
            }

            MEMORY = MEMORY.OrderBy(y => y.Start_add).ToList();

            if (j == Sorted_Holes.Count)
            {
                MessageBox.Show("Process doesn't fit");
                deallocate("P" + process_count);
                segment_count = 0;
                
            }
        }

        public void Worst_fit()
        {
            if (Sorted_Holes.Count != 0)
                Sorted_Holes.RemoveRange(0, Sorted_Holes.Count);

            int i;
            for (i = 0; i < MEMORY.Count; i++)
            {
                if (MEMORY[i].Name == "Hole")
                {
                    // hna5od el Holes n7otaha f List Sorted_Holes b3den n3mlha sort by size
                    Sorted_Holes.Add(new Segment("Hole", MEMORY[i].Start_add, MEMORY[i].Size));
                }
            }
           
            Sorted_Holes = Sorted_Holes.OrderBy(X => X.Size).ToList();

            int j;
            for (j = Sorted_Holes.Count - 1 ; j >= 0 ; j--) //blef 3la el list w h3ml nfs ely f el best bs mn a5er element l2no akbar wa7ed f el size
            {
                if (Sorted_Holes[j].Size == size_seg)
                {
                    Sorted_Holes[j].Name = "P" + process_count + ":" + Name_seg;
                    segment_count++;
                    break;
                }
                else if (Sorted_Holes[j].Size > size_seg)
                {
                    Sorted_Holes.Add(new Segment("P" + process_count + ":" + Name_seg
                                   , Sorted_Holes[j].Start_add, size_seg ));

                    //new hole
                    Sorted_Holes[j].Start_add = Sorted_Holes[j].Start_add + size_seg;
                    Sorted_Holes[j].Size = Sorted_Holes[j].Size - size_seg;

                    Sorted_Holes = Sorted_Holes.OrderBy(X => X.Start_add).ToList();
                    segment_count++;
                    break;
                }
            }

            MEMORY.RemoveAll(p => p.Name == "Hole");

            for (int k = 0; k < Sorted_Holes.Count; k++)
            {

                MEMORY.Add(new Segment( Sorted_Holes[k].Name
                                , Sorted_Holes[k].Start_add, Sorted_Holes[k].Size));
            }
            MEMORY = MEMORY.OrderBy(X => X.Start_add).ToList();
            if (j == - 1 )
            {
                MessageBox.Show("Process doesn't fit");
                deallocate("P" + process_count);
                segment_count = 0;

            }
        }

        public void deallocate ( string p )
        {
            for (int i = 0; i < MEMORY.Count; i++)
            {
             //  MessageBox.Show(MEMORY[i].Name[0].ToString() + MEMORY[i].Name[1]).ToString();

                if (p == ( MEMORY[i].Name[0].ToString() +MEMORY[i].Name[1]).ToString())
                {
                    //Case 1 first instance
                    if (i == 0)
                    {
                        //Case 1 -1 after isn't holes
                        if (MEMORY[i + 1].Name != "Hole")
                        {
                            MEMORY[i].Name = "Hole";
                            
                            //23ml hole count brdo wla l2 !!?
                        }
                        //Case 1 -2 after is a hole
                        else if (MEMORY[i + 1].Name == "Hole")
                        {
                            MEMORY[i + 1].Start_add = MEMORY[i].Start_add;
                            MEMORY[i + 1].Size = MEMORY[i + 1].Size + MEMORY[i].Size;
                            MEMORY.RemoveAt(i);  //biremove at index i y3ny kda process etshalet
                            i--;
                        }
                    }
                    //Case 2  last instance
                    else if (i == MEMORY.Count - 1)
                    {
                        //Case 2 -1 before isn't holes
                        if (MEMORY[i - 1].Name != "Hole")
                        {
                            MEMORY[i].Name = "Hole";
                            //23ml hole count brdo wla l2 !!?
                        }
                        //Case 2 -2 before is a hole
                        //lessa magrbthash 
                        else if (MEMORY[i - 1].Name == "Hole")
                        {
                            MEMORY[i - 1].Size = MEMORY[i - 1].Size + MEMORY[i].Size;
                            MEMORY.RemoveAt(i);
                            i--;
                        }
                    }

                    // Case 3 middle instance
                    //Case 3 -1 before and after aren't holes
                    else if (MEMORY[i - 1].Name != "Hole" && MEMORY[i + 1].Name != "Hole")
                    {
                        MEMORY[i].Name = "Hole";
                        //23ml hole count brdo wla l2 !!?
                    }
                    //Case 3 -2 after only is a hole
                    else if (MEMORY[i - 1].Name != "Hole" && MEMORY[i + 1].Name == "Hole")
                    {
                        
                        MEMORY[i + 1].Start_add = MEMORY[i].Start_add;
                        MEMORY[i + 1].Size = MEMORY[i + 1].Size + MEMORY[i].Size;
                        // MEMORY.Remove()
                        MEMORY.RemoveAt(i);
                        i--;
                    }
                    //Case 3 -3 before only is a hole
                    else if (MEMORY[i - 1].Name == "Hole" && MEMORY[i + 1].Name != "Hole")
                    {
                        MEMORY[i - 1].Size = MEMORY[i - 1].Size + MEMORY[i].Size;
                        MEMORY.RemoveAt(i);
                        i--;
                    }
                    
                    //Case 3 -4 before and after are holes
                    
                    //magrbthaash
                    else if (MEMORY[i - 1].Name == "Hole" && MEMORY[i + 1].Name == "Hole")
                    {
                        MEMORY[i - 1].Size = MEMORY[i - 1].Size + MEMORY[i].Size + MEMORY[i + 1].Size;
                        MEMORY.RemoveAt(i+1);
                        MEMORY.RemoveAt(i);
                        i--;
                    }
                }
                else if (p == (MEMORY[i].Name))
                {
                    if (MEMORY.Count == 1 )
                    {
                        MEMORY[0].Name = "Hole";
                        return;
                    }
                    //Case 1 first instance
                    if (i == 0)
                    {
                        //Case 1 -1 after isn't holes
                        if (MEMORY[i + 1].Name != "Hole")
                        {
                            MEMORY[i].Name = "Hole";
                            //23ml hole count brdo wla l2 !!?
                        }

                        //Case 1 -2 after is a hole
                        else if (MEMORY[i + 1].Name == "Hole")
                        {
                            MEMORY[i + 1].Start_add = MEMORY[i].Start_add;
                            MEMORY[i + 1].Size = MEMORY[i + 1].Size + MEMORY[i].Size;
                            MEMORY.RemoveAt(i);
                            i--;
                        }

                    }
                    //Case 2  last instance
                    else if (i == MEMORY.Count - 1)
                    {
                        //Case 2 -1 before isn't holes
                        if (MEMORY[i - 1].Name != "Hole")
                        {

                            MEMORY[i].Name = "Hole";
                            //23ml hole count brdo wla l2 !!?
                        }

                        //Case 2 -2 before is a hole
                        else if (MEMORY[i - 1].Name == "Hole")
                        {
                            MEMORY[i - 1].Size = MEMORY[i - 1].Size + MEMORY[i].Size;
                            MEMORY.RemoveAt(i);
                            i--;
                        }
                    }
                    // Case 3 middle instance
                    //Case 3 -1 before and after aren't holes
                    else if (MEMORY[i - 1].Name != "Hole" && MEMORY[i + 1].Name != "Hole")
                    {
                        MEMORY[i].Name = "Hole";
                        //23ml hole count brdo wla l2 !!?
                    }

                    //Case 3 -2 after only is a hole
                    else if (MEMORY[i - 1].Name != "Hole" && MEMORY[i + 1].Name == "Hole")
                    {
                        MEMORY[i + 1].Start_add = MEMORY[i].Start_add;
                        MEMORY[i + 1].Size = MEMORY[i + 1].Size + MEMORY[i].Size;
                        MEMORY.RemoveAt(i);
                        i--;
                    }
                    //Case 3 -3 before only is a hole
                    else if (MEMORY[i - 1].Name == "Hole" && MEMORY[i + 1].Name != "Hole")
                    {
                        MEMORY[i - 1].Size = MEMORY[i - 1].Size + MEMORY[i].Size;
                        MEMORY.RemoveAt(i);
                        i--;
                    }
                    //Case 3 -4 before and after are holes
                    else if (MEMORY[i - 1].Name == "Hole" && MEMORY[i + 1].Name == "Hole")
                    {
                        
                        MEMORY[i - 1].Size = MEMORY[i - 1].Size + MEMORY[i].Size + MEMORY[i + 1].Size;
                        MEMORY.RemoveAt(i+1 );
                        MEMORY.RemoveAt(i );
                        i--;
                    }

                }
            }
        }

        private void Add_procees_btn_Click(object sender, EventArgs e)
        {
            if (Allocation_list.SelectedItem == null)
            {
                MessageBox.Show("Choose Method Of Allocation ");
                return;
            }
            No_seg.Clear();
            No_seg.Enabled = true;
            Segments_box.Enabled = true;
        }

        private void Deallocate_btn_Click(object sender, EventArgs e)
        {
            if( Deallocate_box.SelectedItem == null  )
            {
                MessageBox.Show("Choose Process to deallocate ");
                return;
            }

            for (int i = 0; i <= process_count; i++)
            {
                if (Deallocate_box.SelectedItem.ToString() == "P" + i)
                {
                    deallocate("P" + i);
                }
            }

            for (int i = 0 ; i <= old_process_count; i++)
            {
                if (Deallocate_box.SelectedItem.ToString() == "Old Process" + i )
                {
                    deallocate("Old Process" + i );

                }
            }
            Deallocate_box.Items.RemoveAt(Deallocate_box.SelectedIndex);
            Generate_btn_Click(Generate_btn, e);
        }   

        public void Reset_btn_Click(object sender, EventArgs e)
        {
            Clear_btn_Click(Clear_btn, e);
            Memory_size.Enabled = true;
            Memory_size.Clear();
            No_hole.Enabled = true;
            No_hole.Clear();
            starting_add.Clear();
            Hole_size.Clear();
            Holes_box.Enabled = true;

            
            No_seg.Clear();
            No_seg.Enabled = true;
            Seg_name.Clear();
            Seg_size.Clear();
            Segments_box.Enabled = false;

            Allocation_list.SelectedItem = null;
            Allocation_list.Text = "Method Of Allocation";
            Deallocate_box.SelectedItem = null;
            Deallocate_box.Text = "Process";
            
            MEMORY.RemoveRange(0, MEMORY.Count);
            count = 0;
            start = 0;
            old_process_count = 0;
            process_count = 1;
            segment_count = 0;
            txtBox_count = 0;
            Label_count = 0;

            Deallocate_box.Items.Clear();
        }

        public void Clear_btn_Click(object sender, EventArgs e)
        {   
            for ( int i =0 ; i < txtBox_count || i < Label_count  ;i++ )
            {
                foreach (Control item in this.Controls.OfType<Control>())
                    if (item.Name == "myText" || item.Name == "myText1")
                        Controls.Remove(item);

                foreach (Control item in this.Controls.OfType<Control>())
                    if (item.Name == "mylabel" || item.Name == "mylabel1")
                        Controls.Remove(item);
            }
            txtBox_count = 0;
            Label_count = 0;
        }

       
        public void Memory_Load(object sender, EventArgs e)
        {
            Deallocate_box.SelectedItem = null ;
            Allocation_list.SelectedItem = null; 
            

        }

        public void Shuffle_btn_Click(object sender, EventArgs e)
        {

            for(int i =0; i < MEMORY.Count -1 ; i++)
            {
                if (MEMORY[i].Name == "Hole")
                {
                    if (MEMORY[i+1].Name != "Hole" )
                    {
                        MEMORY[i + 1].Start_add = MEMORY[i].Start_add;
                        MEMORY[i].Start_add = MEMORY[i + 1].Start_add + MEMORY[i + 1].Size;
                        MEMORY = MEMORY.OrderBy(X => X.Start_add).ToList();
                    }
                    else
                    {
                        MEMORY[i].Size += MEMORY[i + 1].Size;
                        MEMORY.RemoveAt(i + 1);
                        i--;
                    }
                   
                }

            }
            if ( MEMORY[MEMORY.Count - 1 ].Name == "Hole" )
            {
                if(MEMORY[MEMORY.Count - 2].Name == "Hole")
                {
                    MEMORY[MEMORY.Count - 2].Size += MEMORY[MEMORY.Count - 1].Size;
                    MEMORY.RemoveAt(MEMORY.Count-1);
                }

            }
        }
        private void Deallocate_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Memory_size_txt_Click(object sender, EventArgs e)
        {

        }

        private void Memory_size_TextChanged(object sender, EventArgs e)
        {

        }

        private void Starting_add_txt_Click(object sender, EventArgs e)
        {

        }

        private void Starting_add_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hole_size_txt_Click(object sender, EventArgs e)
        {

        }

        private void Hole_size_TextChanged(object sender, EventArgs e)
        {

        }

        private void No_seg_txt_Click(object sender, EventArgs e)
        {

        }

        private void No_seg_TextChanged(object sender, EventArgs e)
        {

        }

        private void Seg_name_txt_Click(object sender, EventArgs e)
        {

        }

        private void Seg_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Seg_size_txt_Click(object sender, EventArgs e)
        {

        }

        private void Seg_size_TextChanged(object sender, EventArgs e)
        {

        }

        private void Allocation_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Deallocate_ControlAdded(object sender, ControlEventArgs e)
        {
              
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Seg_name_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Start_add_label_Click(object sender, EventArgs e)
        {

        }

       
    }
    public class Segment
    {
        public int Start_add { get; set; }
        public int Size { get; set; }
        public string Name { get; set; }

        public int end => Size + Start_add;

        public Segment(string n, int start, int limit)
        {
            Name = n;
            Start_add = start;
            Size = limit;

        }
    }

   
}


