using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AttackOfTheKarens.code;

public enum Direction {
  LEFT,
  RIGHT,
  UP,
  DOWN
}

namespace AttackOfTheKarens {
  public partial class Form1 : Form {
    private const int CELL_SIZE = 32;
    private PictureBox picOwner;
    private int xOwner;
    private int yOwner;
    private char[][] map;
    private List<Store> stores;

    private Random rand = new Random();
    private Color[] colors = new Color[5] { Color.Red, Color.Green, Color.Blue, Color.Orange, Color.Yellow };

    public Form1() {
      InitializeComponent();
    }

    private void LoadMap() {
      string fileContents = File.ReadAllText("data/mall.txt");
      string[] lines = fileContents.Split(Environment.NewLine);
      map = new char[lines.Length][];
      for (int i = 0; i < lines.Length; i++) {
        map[i] = lines[i].ToCharArray();
      }
    }

    private void GenerateMall(Color color) {
      panMall.Controls.Clear();
      int top = 0;
      int left = 0;

      foreach (char[] array in map) {
        foreach (char c in array) {
          switch (c) {
            case 'K': {
                PictureBox pic = new PictureBox() {
                  Image = Properties.Resources.karen1,
                  Top = top,
                  Left = left,
                  Width = CELL_SIZE,
                  Height = CELL_SIZE,
                };
                pic.Visible = false;
                Karen k = new Karen(pic) {
                   Row = top / CELL_SIZE,
                   Col = left / CELL_SIZE,
                };
                Store s = new Store(k);
                stores.Add(s);
              }
              break;
            case 'o': {
                picOwner = new() {
                  Image = Properties.Resources.owner,
                  Top = top,
                  Left = left,
                  Width = CELL_SIZE,
                  Height = CELL_SIZE,
                };
                xOwner = left / CELL_SIZE;
                yOwner = top / CELL_SIZE;
                panMall.Controls.Add(picOwner);
              }
              break;
            case 'w': {
                PictureBox picWater = new() {
                  Image = Properties.Resources.water,
                  Top = top,
                  Left = left,
                  Width = CELL_SIZE,
                  Height = CELL_SIZE,
                };
                panMall.Controls.Add(picWater);
              }
              break;
            case '-': {
                PictureBox picCell = CreateWall(color, top, left, Properties.Resources.hline);
                panMall.Controls.Add(picCell);
              }
              break;
            case '|': {
                PictureBox picCell = CreateWall(color, top, left, Properties.Resources.vline);
                panMall.Controls.Add(picCell);
              }
              break;
            case 'a': {
                PictureBox picCell = CreateWall(color, top, left, Properties.Resources.a);
                panMall.Controls.Add(picCell);
              }
              break;
            case 'b': {
                PictureBox picCell = CreateWall(color, top, left, Properties.Resources.b);
                panMall.Controls.Add(picCell);
              }
              break;
            case 'c': {
                PictureBox picCell = CreateWall(color, top, left, Properties.Resources.c);
                panMall.Controls.Add(picCell);
              }
              break;
            case 'd': {
                PictureBox picCell = CreateWall(color, top, left, Properties.Resources.d);
                panMall.Controls.Add(picCell);
              }
              break;
            case 'e': {
                PictureBox picCell = CreateWall(color, top, left, Properties.Resources.e);
                panMall.Controls.Add(picCell);
              }
              break;
            case 'f': {
                PictureBox picCell = CreateWall(color, top, left, Properties.Resources.f);
                panMall.Controls.Add(picCell);
              }
              break;
            case 'g': {
                PictureBox picCell = CreateWall(color, top, left, Properties.Resources.g);
                panMall.Controls.Add(picCell);
              }
              break;
            case 'h': {
                PictureBox picCell = CreateWall(color, top, left, Properties.Resources.h);
                panMall.Controls.Add(picCell);
              }
              break;
          }
          left += CELL_SIZE;
        }
        left = 0;
        top += CELL_SIZE;
      }

      picOwner.BringToFront();
      panMall.Width = CELL_SIZE * map[0].Length + 10;
      panMall.Height = CELL_SIZE * map.Length + 10;
      this.Width = panMall.Width + 30;
      this.Height = panMall.Height + 50;
    }
    
    private PictureBox CreateWall(Color color, int top, int left, Image img) {
      PictureBox picWall = new() {
        Image = img,
        Top = top,
        Left = left,
        Width = CELL_SIZE,
        Height = CELL_SIZE,
      };
      picWall.Image.Tint(color);
      return picWall;
    }

    private void Form1_Load(object sender, EventArgs e) {
      stores = new List<Store>();
      LoadMap();
      GenerateMall(colors[rand.Next(colors.Length)]);
      tmrKarenSpawner.Interval = rand.Next(1000, 5000);
      tmrKarenSpawner.Enabled = true;
    }

    private bool IsInBounds(int newRow, int newCol) {
      return (newRow >= 0 && newRow < map.Length && newCol >= 0 && newCol < map[0].Length);
    }

    private bool IsWalkable(int newRow, int newCol) {
      return map[newRow][newCol] == ' ' || map[newRow][newCol] == 'o' || map[newRow][newCol] == 'K';
    }

    private bool CanMove(Direction dir, out int newRow, out int newCol) {
      newRow = yOwner;
      newCol = xOwner;
      switch (dir) {
        case Direction.UP: newRow--; break;
        case Direction.DOWN: newRow++; break;
        case Direction.LEFT: newCol--; break;
        case Direction.RIGHT: newCol++; break;
      }
      return (IsInBounds(newRow, newCol) && IsWalkable(newRow, newCol));
    }
    private new void Move(Direction dir) {
      if (CanMove(dir, out int newRow, out int newCol)) {
        yOwner = newRow;
        xOwner = newCol;
        picOwner.Top = yOwner * CELL_SIZE;
        picOwner.Left = xOwner * CELL_SIZE;
      }
    }

    private void Form1_KeyUp(object sender, KeyEventArgs e) {
      switch (e.KeyCode) {
        case Keys.Up: Move(Direction.UP); break;
        case Keys.Down: Move(Direction.DOWN); break;
        case Keys.Left: Move(Direction.LEFT); break;
        case Keys.Right: Move(Direction.RIGHT); break;
      }
    }

    private void tmrKarenSpawner_Tick(object sender, EventArgs e) {
      Store s = stores[rand.Next(stores.Count)];
      s.ActivateTheKaren();
    }
  }
}
