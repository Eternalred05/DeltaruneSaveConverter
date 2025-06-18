﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeltaruneSaveConverter
{
    class DeltaruneCh1
    {
        public string truename = "";
        public string[] othername = new string[6];
        public double[] Char = new double[3];
        public double gold = 0;
        public double xp = 0;
        public double lv = 0;
        public double inv = 0;
        public double invc = 0;
        public double darkzone = 0;
        public double[] hp = new double[4];
        public double[] maxhp = new double[4];
        public double[] at = new double[4];
        public double[] df = new double[4];
        public double[] mag = new double[4];
        public double[] guts = new double[4];
        public double[] charweapon = new double[4];
        public double[] chararmor1 = new double[4];
        public double[] chararmor2 = new double[4];
        public string[] weaponstyle = new string[4];
        public double[,] itemat = new double[4, 4];
        public double[,] itemdf = new double[4, 4];
        public double[,] itemmag = new double[4, 4];
        public double[,] itembolts = new double[4, 4];
        public double[,] itemgrazeamt = new double[4, 4];
        public double[,] itemgrazesize = new double[4, 4];
        public double[,] itemboltspeed = new double[4, 4];
        public double[,] itemspecial = new double[4, 4];
        public double[,] spell = new double[4, 12];
        public double boltspeed = 0;
        public double grazeamt = 0;
        public double grazesize = 0;
        public double[] item = new double[13];
        public double[] keyitem = new double[13];
        public double[] weapon = new double[13];
        public double[] armor = new double[13];
        public double tension = 0;
        public double maxtension = 0;
        public double lweapon = 0;
        public double larmor = 0;
        public double lxp = 0;
        public double llv = 0;
        public double lgold = 0;
        public double lhp = 0;
        public double lmaxhp = 0;
        public double lat = 0;
        public double ldf = 0;
        public double lwstrength = 0;
        public double ladef = 0;
        public double[] litem = new double[8];
        public double[] phone = new double[8];
        public double[] flag = new double[9999];
        public double plot = 0;
        public double currentroom = 0;
        public double time = 0;

        public void ReadFromPCFile(string PCFilePath)
        {
            string[] filelines = File.ReadAllLines(PCFilePath);
            int line = 0;
            truename = filelines[line];
            line++;
            for (int i = 0; i < 6; i++)
            {
                othername[i] = filelines[line];
                line++;
            }
            for (int i = 0; i < 3; i++)
            {
                Char[i] = Convert.ToDouble(filelines[line]);
                line++;
            }
            gold = Convert.ToDouble(filelines[line]);
            line++;
            xp = Convert.ToDouble(filelines[line]);
            line++;
            lv = Convert.ToDouble(filelines[line]);
            line++;
            inv = Convert.ToDouble(filelines[line]);
            line++;
            invc = Convert.ToDouble(filelines[line]);
            line++;
            darkzone = Convert.ToDouble(filelines[line]);
            line++;
            for (int i = 0; i < 4; i++)
            {
                hp[i] = Convert.ToDouble(filelines[line]);
                line++;
                maxhp[i] = Convert.ToDouble(filelines[line]);
                line++;
                at[i] = Convert.ToDouble(filelines[line]);
                line++;
                df[i] = Convert.ToDouble(filelines[line]);
                line++;
                mag[i] = Convert.ToDouble(filelines[line]);
                line++;
                guts[i] = Convert.ToDouble(filelines[line]);
                line++;
                charweapon[i] = Convert.ToDouble(filelines[line]);
                line++;
                chararmor1[i] = Convert.ToDouble(filelines[line]);
                line++;
                chararmor2[i] = Convert.ToDouble(filelines[line]);
                line++;
                weaponstyle[i] = filelines[line];
                line++;
                for (int q = 0; q < 4; q++)
                {
                    itemat[i, q] = Convert.ToDouble(filelines[line]);
                    line++;
                    itemdf[i, q] = Convert.ToDouble(filelines[line]);
                    line++;
                    itemmag[i, q] = Convert.ToDouble(filelines[line]);
                    line++;
                    itembolts[i, q] = Convert.ToDouble(filelines[line]);
                    line++;
                    itemgrazeamt[i, q] = Convert.ToDouble(filelines[line]);
                    line++;
                    itemgrazesize[i, q] = Convert.ToDouble(filelines[line]);
                    line++;
                    itemboltspeed[i, q] = Convert.ToDouble(filelines[line]);
                    line++;
                    itemspecial[i, q] = Convert.ToDouble(filelines[line]);
                    line++;
                }
                for (int j = 0; j < 12; j++)
                {
                    spell[i, j] = Convert.ToDouble(filelines[line]);
                    line++;
                }
            }
            boltspeed = Convert.ToDouble(filelines[line]);
            line++;
            grazeamt = Convert.ToDouble(filelines[line]);
            line++;
            grazesize = Convert.ToDouble(filelines[line]);
            line++;
            for (int j = 0; j < 13; j++)
            {
                item[j] = Convert.ToDouble(filelines[line]);
                line++;
                keyitem[j] = Convert.ToDouble(filelines[line]);
                line++;
                weapon[j] = Convert.ToDouble(filelines[line]);
                line++;
                armor[j] = Convert.ToDouble(filelines[line]);
                line++;
            }
            tension = Convert.ToDouble(filelines[line]);
            line++;
            maxtension = Convert.ToDouble(filelines[line]);
            line++;
            lweapon = Convert.ToDouble(filelines[line]);
            line++;
            larmor = Convert.ToDouble(filelines[line]);
            line++;
            lxp = Convert.ToDouble(filelines[line]);
            line++;
            llv = Convert.ToDouble(filelines[line]);
            line++;
            lgold = Convert.ToDouble(filelines[line]);
            line++;
            lhp = Convert.ToDouble(filelines[line]);
            line++;
            lmaxhp = Convert.ToDouble(filelines[line]);
            line++;
            lat = Convert.ToDouble(filelines[line]);
            line++;
            ldf = Convert.ToDouble(filelines[line]);
            line++;
            lwstrength = Convert.ToDouble(filelines[line]);
            line++;
            ladef = Convert.ToDouble(filelines[line]);
            line++;
            for (int i = 0; i < 8; i++)
            {
                litem[i] = Convert.ToDouble(filelines[line]);
                line++;
                phone[i] = Convert.ToDouble(filelines[line]);
                line++;
            }
            for (int i = 0; i < 9999; i++)
            {
                flag[i] = Convert.ToDouble(filelines[line]);
                line++;
            }
            plot = Convert.ToDouble(filelines[line]);
            line++;
            currentroom = Convert.ToDouble(filelines[line]);
            line++;
            time = Convert.ToDouble(filelines[line]);
        }

        public void WriteToPCFile(string PCFilePath)
        {
            string[] filelines = new string[10318];
            int line = 0;
            filelines[line] = truename;
            line++;
            for (int i = 0; i < 6; i++)
            {
                filelines[line] = othername[i];
                line++;
            }
            for (int i = 0; i < 3; i++)
            {
                filelines[line] = Char[i].ToString();
                line++;
            }
            filelines[line] = gold.ToString();
            line++;
            filelines[line] = xp.ToString();
            line++;
            filelines[line] = lv.ToString();
            line++;
            filelines[line] = inv.ToString();
            line++;
            filelines[line] = invc.ToString();
            line++;
            filelines[line] = darkzone.ToString();
            line++;
            for (int i = 0; i < 4; i++)
            {
                filelines[line] = hp[i].ToString();
                line++;
                filelines[line] = maxhp[i].ToString();
                line++;
                filelines[line] = at[i].ToString();
                line++;
                filelines[line] = df[i].ToString();
                line++;
                filelines[line] = mag[i].ToString();
                line++;
                filelines[line] = guts[i].ToString();
                line++;
                filelines[line] = charweapon[i].ToString();
                line++;
                filelines[line] = chararmor1[i].ToString();
                line++;
                filelines[line] = chararmor2[i].ToString();
                line++;
                filelines[line] = weaponstyle[i];
                line++;
                for (int q = 0; q < 4; q++)
                {
                    filelines[line] = itemat[i, q].ToString();
                    line++;
                    filelines[line] = itemdf[i, q].ToString();
                    line++;
                    filelines[line] = itemmag[i, q].ToString();
                    line++;
                    filelines[line] = itembolts[i, q].ToString();
                    line++;
                    filelines[line] = itemgrazeamt[i, q].ToString();
                    line++;
                    filelines[line] = itemgrazesize[i, q].ToString();
                    line++;
                    filelines[line] = itemboltspeed[i, q].ToString();
                    line++;
                    filelines[line] = itemspecial[i, q].ToString();
                    line++;
                }
                for (int j = 0; j < 12; j++)
                {
                    filelines[line] = spell[i, j].ToString();
                    line++;
                }
            }
            filelines[line] = boltspeed.ToString();
            line++;
            filelines[line] = grazeamt.ToString();
            line++;
            filelines[line] = grazesize.ToString();
            line++;
            for (int j = 0; j < 13; j++)
            {
                filelines[line] = item[j].ToString();
                line++;
                filelines[line] = keyitem[j].ToString();
                line++;
                filelines[line] = weapon[j].ToString();
                line++;
                filelines[line] = armor[j].ToString();
                line++;
            }
            filelines[line] = tension.ToString();
            line++;
            filelines[line] = maxtension.ToString();
            line++;
            filelines[line] = lweapon.ToString();
            line++;
            filelines[line] = larmor.ToString();
            line++;
            filelines[line] = lxp.ToString();
            line++;
            filelines[line] = llv.ToString();
            line++;
            filelines[line] = lgold.ToString();
            line++;
            filelines[line] = lhp.ToString();
            line++;
            filelines[line] = lmaxhp.ToString();
            line++;
            filelines[line] = lat.ToString();
            line++;
            filelines[line] = ldf.ToString();
            line++;
            filelines[line] = lwstrength.ToString();
            line++;
            filelines[line] = ladef.ToString();
            line++;
            for (int i = 0; i < 8; i++)
            {
                filelines[line] = litem[i].ToString();
                line++;
                filelines[line] = phone[i].ToString();
                line++;
            }
            for (int i = 0; i < 9999; i++)
            {
                filelines[line] = flag[i].ToString();
                line++;
            }
            filelines[line] = plot.ToString();
            line++;
            filelines[line] = currentroom.ToString();
            line++;
            filelines[line] = time.ToString();
            File.WriteAllText(PCFilePath, string.Join("\r\n", filelines));
        }

        public void ReadFromConsoleFile(string ConsoleFilePath)
        {
            string[] filelines = File.ReadAllLines(ConsoleFilePath);
            int line = 0;
            truename = filelines[line];
            line++;
            new GMSListDecoder(filelines[line]).ToStringArray(ref othername, 6);
            line++;
            for (int i = 0; i < 3; i++)
            {
                Char[i] = Convert.ToDouble(filelines[line]);
                line++;
            }
            gold = Convert.ToDouble(filelines[line]);
            line++;
            xp = Convert.ToDouble(filelines[line]);
            line++;
            lv = Convert.ToDouble(filelines[line]);
            line++;
            inv = Convert.ToDouble(filelines[line]);
            line++;
            invc = Convert.ToDouble(filelines[line]);
            line++;
            darkzone = Convert.ToDouble(filelines[line]);
            line++;
            new GMSListDecoder(filelines[line]).ToRealArray(ref hp, 4);
            line++;
            new GMSListDecoder(filelines[line]).ToRealArray(ref maxhp, 4);
            line++;
            new GMSListDecoder(filelines[line]).ToRealArray(ref at, 4);
            line++;
            new GMSListDecoder(filelines[line]).ToRealArray(ref df, 4);
            line++;
            new GMSListDecoder(filelines[line]).ToRealArray(ref mag, 4);
            line++;
            new GMSListDecoder(filelines[line]).ToRealArray(ref guts, 4);
            line++;
            new GMSListDecoder(filelines[line]).ToRealArray(ref charweapon, 4);
            line++;
            new GMSListDecoder(filelines[line]).ToRealArray(ref chararmor1, 4);
            line++;
            new GMSListDecoder(filelines[line]).ToRealArray(ref chararmor2, 4);
            line++;
            new GMSListDecoder(filelines[line]).ToStringArray(ref weaponstyle, 4);
            line++;
            for (int i = 0; i < 4; i++)
            {
                for (int q = 0; q < 4; q++)
                {
                    itemat[i, q] = Convert.ToDouble(filelines[line]);
                    line++;
                    itemdf[i, q] = Convert.ToDouble(filelines[line]);
                    line++;
                    itemmag[i, q] = Convert.ToDouble(filelines[line]);
                    line++;
                    itembolts[i, q] = Convert.ToDouble(filelines[line]);
                    line++;
                    itemgrazeamt[i, q] = Convert.ToDouble(filelines[line]);
                    line++;
                    itemgrazesize[i, q] = Convert.ToDouble(filelines[line]);
                    line++;
                    itemboltspeed[i, q] = Convert.ToDouble(filelines[line]);
                    line++;
                    itemspecial[i, q] = Convert.ToDouble(filelines[line]);
                    line++;
                }
                for (int j = 0; j < 12; j++)
                {
                    spell[i, j] = Convert.ToDouble(filelines[line]);
                    line++;
                }
            }
            boltspeed = Convert.ToDouble(filelines[line]);
            line++;
            grazeamt = Convert.ToDouble(filelines[line]);
            line++;
            grazesize = Convert.ToDouble(filelines[line]);
            line++;
            new GMSListDecoder(filelines[line]).ToRealArray(ref item, 13);
            line++;
            new GMSListDecoder(filelines[line]).ToRealArray(ref keyitem, 13);
            line++;
            new GMSListDecoder(filelines[line]).ToRealArray(ref weapon, 13);
            line++;
            new GMSListDecoder(filelines[line]).ToRealArray(ref armor, 13);
            line++;
            tension = Convert.ToDouble(filelines[line]);
            line++;
            maxtension = Convert.ToDouble(filelines[line]);
            line++;
            lweapon = Convert.ToDouble(filelines[line]);
            line++;
            larmor = Convert.ToDouble(filelines[line]);
            line++;
            lxp = Convert.ToDouble(filelines[line]);
            line++;
            llv = Convert.ToDouble(filelines[line]);
            line++;
            lgold = Convert.ToDouble(filelines[line]);
            line++;
            lhp = Convert.ToDouble(filelines[line]);
            line++;
            lmaxhp = Convert.ToDouble(filelines[line]);
            line++;
            lat = Convert.ToDouble(filelines[line]);
            line++;
            ldf = Convert.ToDouble(filelines[line]);
            line++;
            lwstrength = Convert.ToDouble(filelines[line]);
            line++;
            ladef = Convert.ToDouble(filelines[line]);
            line++;
            new GMSListDecoder(filelines[line]).ToRealArray(ref litem, 8);
            line++;
            new GMSListDecoder(filelines[line]).ToRealArray(ref phone, 8);
            line++;
            new GMSListDecoder(filelines[line]).ToRealArray(ref flag, 9999);
            line++;
            plot = Convert.ToDouble(filelines[line]);
            line++;
            currentroom = Convert.ToDouble(filelines[line]);
            line++;
            time = Convert.ToDouble(filelines[line]);
        }

        public void WriteToConsoleFile(string ConsoleFilePath)
        {
            string[] filelines = new string[223];
            int line = 0;
            filelines[line] = truename;
            line++;
            filelines[line] = new GMSListEncoder(othername).GetString();
            line++;
            for (int i = 0; i < 3; i++)
            {
                filelines[line] = Char[i].ToString();
                line++;
            }
            filelines[line] = gold.ToString();
            line++;
            filelines[line] = xp.ToString();
            line++;
            filelines[line] = lv.ToString();
            line++;
            filelines[line] = inv.ToString();
            line++;
            filelines[line] = invc.ToString();
            line++;
            filelines[line] = darkzone.ToString();
            line++;
            filelines[line] = new GMSListEncoder(hp).GetString();
            line++;
            filelines[line] = new GMSListEncoder(maxhp).GetString();
            line++;
            filelines[line] = new GMSListEncoder(at).GetString();
            line++;
            filelines[line] = new GMSListEncoder(df).GetString();
            line++;
            filelines[line] = new GMSListEncoder(mag).GetString();
            line++;
            filelines[line] = new GMSListEncoder(guts).GetString();
            line++;
            filelines[line] = new GMSListEncoder(charweapon).GetString();
            line++;
            filelines[line] = new GMSListEncoder(chararmor1).GetString();
            line++;
            filelines[line] = new GMSListEncoder(chararmor2).GetString();
            line++;
            filelines[line] = new GMSListEncoder(weaponstyle).GetString();
            line++;
            for (int i = 0; i < 4; i++)
            {
                for (int q = 0; q < 4; q++)
                {
                    filelines[line] = itemat[i, q].ToString();
                    line++;
                    filelines[line] = itemdf[i, q].ToString();
                    line++;
                    filelines[line] = itemmag[i, q].ToString();
                    line++;
                    filelines[line] = itembolts[i, q].ToString();
                    line++;
                    filelines[line] = itemgrazeamt[i, q].ToString();
                    line++;
                    filelines[line] = itemgrazesize[i, q].ToString();
                    line++;
                    filelines[line] = itemboltspeed[i, q].ToString();
                    line++;
                    filelines[line] = itemspecial[i, q].ToString();
                    line++;
                }
                for (int j = 0; j < 12; j++)
                {
                    filelines[line] = spell[i, j].ToString();
                    line++;
                }
            }
            filelines[line] = boltspeed.ToString();
            line++;
            filelines[line] = grazeamt.ToString();
            line++;
            filelines[line] = grazesize.ToString();
            line++;
            filelines[line] = new GMSListEncoder(item).GetString();
            line++;
            filelines[line] = new GMSListEncoder(keyitem).GetString();
            line++;
            filelines[line] = new GMSListEncoder(weapon).GetString();
            line++;
            filelines[line] = new GMSListEncoder(armor).GetString();
            line++;
            filelines[line] = tension.ToString();
            line++;
            filelines[line] = maxtension.ToString();
            line++;
            filelines[line] = lweapon.ToString();
            line++;
            filelines[line] = larmor.ToString();
            line++;
            filelines[line] = lxp.ToString();
            line++;
            filelines[line] = llv.ToString();
            line++;
            filelines[line] = lgold.ToString();
            line++;
            filelines[line] = lhp.ToString();
            line++;
            filelines[line] = lmaxhp.ToString();
            line++;
            filelines[line] = lat.ToString();
            line++;
            filelines[line] = ldf.ToString();
            line++;
            filelines[line] = lwstrength.ToString();
            line++;
            filelines[line] = ladef.ToString();
            line++;
            filelines[line] = new GMSListEncoder(litem).GetString();
            line++;
            filelines[line] = new GMSListEncoder(phone).GetString();
            line++;
            filelines[line] = new GMSListEncoder(flag).GetString();
            line++;
            filelines[line] = plot.ToString();
            line++;
            filelines[line] = currentroom.ToString();
            line++;
            filelines[line] = time.ToString();
            File.WriteAllText(ConsoleFilePath, string.Join("\r\n", filelines));
        }

        public static bool IsPCSaveFile(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            return lines.Length == 10318;
        }

        public static bool IsConsoleSaveFile(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            return lines.Length == 223;
        }
    }
}
