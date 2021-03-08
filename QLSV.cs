using System;

namespace VSCODECSHARP
{
    class QLSV
    {
        public SV[] listSV {get; set;}
        public int n {get; set;}

        public QLSV() {
            listSV = null;
            n = 0;
        }

        public void Add(SV s) {
            if (listSV == null || n == 0) {
                n = 1;
                listSV = new SV[1];
                listSV[0] = s;
            }
            else {
                SV[] listSVTemp = new SV[n+1];
                for (int i = 0; i < n; i++) {
                    listSVTemp[i] = listSV[i];
                }
                listSVTemp[n] = s;
                n += 1;
                listSV = listSVTemp;
            }
        }

        public void Insert(SV sv, int index) {
            SV[] listSVTemp = new SV[n+1];
            for (int i = 0; i < index; i++) {
                listSVTemp[i] = listSV[i];
            }
            listSVTemp[index] = sv;
            for (int i = index + 1; i < n+1; i++) {
                listSVTemp[i] = listSV[i-1];
            }
            listSV = listSVTemp;
        }

        public int IndexOf(SV s) {
            int index = -1;
            for (int i = 0; i < n; i++) {
                if (listSV[i] == s) {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public void RemoveAt(int index) {
            if (0 <= index && index <= n-1) {
                SV[] temp = new SV[n-1];
                for (int i = 0; i < index; i++) {
                    temp[i] = listSV[i];
                }
                for (int i = index + 1; i < n; i++) {
                    temp[i-1] = listSV[i];
                }
                listSV = temp;
                n -= 1;
            }
            else Console.WriteLine("No index {0}.\nIndex must be in {1} -> {2}!\n", index, 0, n-1);
        }

        public void Remove(SV s) {
            while (IndexOf(s) > -1) {
                RemoveAt(IndexOf(s));
            }
        }

        public void Update(int MSSV) {
            for (int i = 0; i < n; i++) {
                if (listSV[i].MSSV == MSSV) {
                    listSV[i].Ten = "AAA";
                }
            }
        }

        public void Sort() {
            for (int i = 0; i < n; i++) {
                for (int j = i+1; j < n; j++) {
                    if (listSV[i].MSSV < listSV[j].MSSV) {
                        SV temp = listSV[i];
                        listSV[i] = listSV[j];
                        listSV[j] = temp;
                    }
                }
            }
        }

        public override string ToString() {
            string str = "";
            foreach (SV i in listSV) {
                str += string.Format("Ten: {0}; MSSV: {1}; DTB: {2}\n", i.Ten, i.MSSV, i.DTB);
            }
            return str;
        }
    }
}