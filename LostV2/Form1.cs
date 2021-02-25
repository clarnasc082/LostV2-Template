/// created by : Clara Nascu
/// date       : Feb 25, 2021
/// description: A basic text adventure game engine

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace LostV2
{
    public partial class Form1 : Form
    {
        // tracks what part of the game the user is at
        int scene = 0;

        public Form1()
        {
            InitializeComponent();
            SoundPlayer player = new SoundPlayer(Properties.Resources._449092__dobroide__20181018_scream03);
            player.Play();
            //display initial message and options
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 0)
                {
                    scene = 3;
                    Random randGen = new Random();
                    int value = randGen.Next(1, 11);
                    if (value < 4) { scene = 3; }
                    else { scene = 1; }
                }
                else if (scene == 1) { scene = 4; }
                else if (scene == 2) { scene = 13; }
                else if (scene == 3) { scene = 0; }
                else if (scene == 4) { scene = 5; }
                else if (scene == 5) { scene = 7; }
                else if (scene == 6) { scene = 0; }
                else if (scene == 7) { scene = 12; }
                else if (scene == 8) { scene = 24; }
                else if (scene == 9) { scene = 0; }
                else if (scene == 10) { scene = 0; }
                else if (scene == 11) { scene = 0; }
                else if (scene == 12) { scene = 0; }
                else if (scene == 13) { scene = 22; }
                else if (scene == 14) { scene = 16; }
                else if (scene == 15) { scene = 0; }
                else if (scene == 16) { scene = 0; }
                else if (scene == 17) { scene = 0; }
                else if (scene == 18) { scene = 0; }
                else if (scene == 19) { scene = 21; }
                else if (scene == 20) { scene = 0; }
                else if (scene == 21) { scene = 0; }
                else if (scene == 22) { scene = 0; }
                else if (scene == 23) { scene = 0; }
                else if (scene == 24) { scene = 0; }
            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 0)
                {
                    scene = 2;
                }
                else if (scene == 1) { scene = 6; }
                else if (scene == 2) { scene = 17; }
                else if (scene == 3) { scene = 99; }
                else if (scene == 4) { scene = 8; }
                else if (scene == 5) { scene = 23; }
                else if (scene == 6) { scene = 99; }
                else if (scene == 7) { scene = 9; }
                else if (scene == 8) 
                {
                    Random randGen = new Random();
                    int value = randGen.Next(1, 11);
                    if (value < 2) { scene = 10; }
                    else { scene = 11; } 
                }
                else if (scene == 9) { scene = 99; }
                else if (scene == 10) { scene = 99; }
                else if (scene == 11) { scene = 99; }
                else if (scene == 12) { scene = 99; }
                else if (scene == 13) { scene = 14; }
                else if (scene == 14) { scene = 18; }
                else if (scene == 15) { scene = 99; }
                else if (scene == 16) { scene = 99; }
                else if (scene == 17) { scene = 99; }
                else if (scene == 18) { scene = 99; }
                else if (scene == 19) { scene = 20; }
                else if (scene == 20) { scene = 99; }
                else if (scene == 21) { scene = 99; }
                else if (scene == 22) { scene = 99; }
                else if (scene == 23) { scene = 99; }
                else if (scene == 24) { scene = 99; }

            }

            else if (e.KeyCode == Keys.Space)
            {
                if (scene == 0) { scene = 0; }
                else if (scene == 1) { scene = 1; }
                else if (scene == 2) { scene = 2; }
                else if (scene == 3) { scene = 3; }
                else if (scene == 4) { scene = 4; }
                else if (scene == 5) { scene = 5; }
                else if (scene == 6) { scene = 6; }
                else if (scene == 7) { scene = 7; }
                else if (scene == 8) { scene = 8; }
                else if (scene == 9) { scene = 9; }
                else if (scene == 10) { scene = 10; }
                else if (scene == 11) { scene = 11; }
                else if (scene == 12) { scene = 12; }
                else if (scene == 13) { scene = 15; }
                else if (scene == 14) { scene = 19; }
                else if (scene == 15) { scene = 15; }
                else if (scene == 16) { scene = 16; }
                else if (scene == 17) { scene = 17; }
                else if (scene == 18) { scene = 18; }
                else if (scene == 19) { scene = 19; }
                else if (scene == 20) { scene = 20; }
                else if (scene == 21) { scene = 21; }
                else if (scene == 22) { scene = 22; }
                else if (scene == 23) { scene = 23; }
                else if (scene == 24) { scene = 24; }
            }

            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                case 0:  //start scene  
                    outputLabel.Text = "The end of the world has arrived. Giant man eating plants are killing people and your friends have gone crazy. You are hiding in your house. What do you choose to do?";
                    redLabel.Text = "Stay inside";
                    blueLabel.Text = "Go outside";
                    greenLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.aa5ef710a610180e7beafb850dc0f745;
                    SoundPlayer player = new SoundPlayer(Properties.Resources._449092__dobroide__20181018_scream03);
                    player.Play();
                    break;
                case 1:
                    outputLabel.Text = "You eat some leftover pizza. The doorbell rings. Do you answer it??";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.leftover_pizza;
                    break;
                case 2:
                    outputLabel.Text = "You step outside and see the chaos unleash around you. People are running and screaming, burning fires everywhere. There is a blowtorch on the ground. Pick it up??";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources._3401;
                    player = new SoundPlayer(Properties.Resources._555382__samsterbirdies__scary_noise);
                    player.Play();
                    break;
                case 3:
                    outputLabel.Text = "A meteorite hits your house and kills you. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources._5846e386e02ba735318b74dc;
                    break;
                case 4:
                    outputLabel.Text = "It's your friend Stacy! She is covered in the blood of her enemies and wants to talk. Do you let her in?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.stacy_blood;
                    player = new SoundPlayer(Properties.Resources._1013__rhumphries__rbh_household_drip_01);
                    player.Play();
                    break;
                case 5:
                    outputLabel.Text = "You let her in. She can probably help you. The two of you talk about what to do and she asks if you want to go to the forest with her. Do you go?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.inside_house;
                    break;
                case 6:
                    outputLabel.Text = " Your old friend Stacy breaks into your house and stabs you to death. Stacy was never a great friend. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.Stacy_stab;
                    player = new SoundPlayer(Properties.Resources._50817__scriptique__knife_slides);
                    player.Play();
                    break;
                case 7:
                    outputLabel.Text = " You follow Stacy to the forest but start to get chills. Something bad is about to happen. Do you run away?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.forest_chill;
                    break;
                case 8:
                    outputLabel.Text = " She looks angry but walks away. You cant take any chances. Stacy was mean to you in middle school. Do you go outside now?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.angry_stacy;
                    player = new SoundPlayer(Properties.Resources._402024__cybermad__creepy_ambient);
                    player.Play();
                    break;
                case 9:
                    outputLabel.Text = " You make it to a clearing in the forest and find out that Stacy is the leader of the man eating plant cult in your neighborhood. You team up with her and survive the apocalypse riding giant monster plants and murdering people. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.cult;
                    break;
                case 10:
                    outputLabel.Text = " You make an under-ground bunker and survive the End of the world. Play again? ";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.bunker;
                    player = new SoundPlayer(Properties.Resources.Store_Door_Chime_Mike_Koenig_570742973);
                    player.Play();
                    break;
                case 11:
                    outputLabel.Text = " A mutant bird gets into your house and eats all your food. You starve to death. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.mutant_bird;
                    break;
                case 12:
                    outputLabel.Text = " While running away, you trip on a log and fall off a cliff. Oh well. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.clif_fall;
                    sceneImage.BackgroundImage = Properties.Resources.bunker;
                    break;
                case 13:
                    outputLabel.Text = " A giant man eating plant comes up from behind you but you blowtorch it and escape. Suddenly the phone in your pocket rings. What do you do?";
                    redLabel.Text = "Answer it";
                    blueLabel.Text = "Throw it away";
                    greenLabel.Text = "Ignore it";
                    sceneImage.BackgroundImage = Properties.Resources.plant_eating;
                    break;
                case 14:
                    outputLabel.Text = " You chuck the phone in the river and a portal to another dimension appears. What do you do?";
                    redLabel.Text = "Throw rock in portal";
                    blueLabel.Text = "Enter portal";
                    greenLabel.Text = "Walk away";
                    sceneImage.BackgroundImage = Properties.Resources.portal;
                    break;
                case 15:
                    outputLabel.Text = " You ignore it and start playing candy crush. You don't notice a figure behind you until it's too late. Your old friend Stacy stabs you to death. She sucks. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.Stacy_stabing;
                    break;
                case 16:
                    outputLabel.Text = " You throw a rock in the portal and it disappears. In it's place is a safehouse. You survived! Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.safehouse;
                    break;
                case 17:
                    outputLabel.Text = " A giant man eating plant comes up from behind you and bites of your head. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.plant_food;
                    break;
                case 18:
                    outputLabel.Text = " You enter the portal and get teleported into a volcano. Tough luck. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.volcano;
                    break;
                case 19:
                    outputLabel.Text = " You walk away from the portal. It was probably a trap anyways. A tiny bug lands on your arm. Do you kill it?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.fly;
                    break;
                case 20:
                    outputLabel.Text = " The bug bites you and you die. Rude. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.death;
                    break;
                case 21:
                    outputLabel.Text = " The bug was actually a God and you stopped the apocalypse. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.god;
                    break;
                case 22:
                    outputLabel.Text = " You answer it. The government now has your location and nukes your whole neighborhood. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.nuke;
                    break;
                case 23:
                    outputLabel.Text = " Stacy kills you with a butter knife. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.blood_hand;
                    break;
                case 24:
                    outputLabel.Text = " You step outside, but Stacy comes up from behind you and strangles you. Aw man. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.bloody;
                    break;
                case 99: 
                    //Ending scene - change output label text and button labels text

                    sceneImage.BackgroundImage = Properties.Resources.game;
                    Refresh();
                    Thread.Sleep(500);
                    outputLabel.Text = "Thanks for playing";
                    Refresh();
                    Thread.Sleep(2000);
                    outputLabel.Text = "Good luck in the next apocolypse...";
                    redLabel.Text = " ERROR";
                    blueLabel.Text = " ERROR";
                    greenLabel.Text = " ERROR";
                    Refresh();
                    Thread.Sleep(500);
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    Refresh();
                    Thread.Sleep(500);
                    redLabel.Text = " ERROR";
                    blueLabel.Text = " ERROR";
                    greenLabel.Text = " ERROR";
                    Refresh();
                    Thread.Sleep(500);
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    Refresh();
                    Thread.Sleep(500);
                    redLabel.Text = " ERROR";
                    blueLabel.Text = " ERROR";
                    greenLabel.Text = " ERROR";
                    break;
                default:
                    break;
            }
        }
    }
}
