﻿using System.Collections.Generic;
using UnityEngine;

namespace UmbraMenu
{
    public class ListMenu : IMenu
    {
        public float delay = 0, heightMulY = 15;
        public float WidthSize { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public bool enabled { get; set; }
        public Rect Rect { get; set; }
        public bool IfDragged { get; set; }
        public int NumberOfButtons { get; set; }
        public Button ActivatingButton { get; set; }
        public int PrevMenuId { get; set; }
        public List<Button> Buttons { get; set; }
        public bool Enabled
        {
            get
            {
                return enabled;
            }
            set
            {
                enabled = value;
                UmbraMenu.previousMenuOpen = Id;
                if (UmbraMenu.navigationToggle && value)
                {
                    Navigation.menuIndex = Id;
                }

                if (enabled)
                {
                    ActivatingButton?.SetEnabled(true);
                }
                else
                {
                    ActivatingButton?.SetEnabled(false);
                }
            }
        }

        public Vector2 CurrentScrollPosition { get; set; }

        public ListMenu(int id, Rect rect, string title)
        {
            Id = id;
            Rect = rect;
            Title = title;
            NumberOfButtons = 0;
            WidthSize = UmbraMenu.Width;

            if (UmbraMenu.lowResolutionMonitor)
            {
                heightMulY = 10;
            }
        }

        public void SetWindow()
        {
            Rect = GUI.Window(Id, Rect, new GUI.WindowFunction(SetBackground), "", new GUIStyle());
        }

        public virtual void Draw()
        {
            if (Enabled)
            {
                GUI.Box(new Rect(Rect.x, Rect.y, WidthSize + 10, 50f + 45 * heightMulY), "", Styles.MainBgStyle);
                GUI.Label(new Rect(Rect.x + 5f, Rect.y + 5f, WidthSize + 5, 85f), Title, Styles.TitleStyle);
                DrawAllButtons();
            }
        }

        public virtual void Reset()
        {
            Enabled = false;
            IfDragged = false;
        }

        private void DrawAllButtons()
        {
            CurrentScrollPosition = GUI.BeginScrollView(new Rect(Rect.x, Rect.y, WidthSize + 10, 50f + 45 * heightMulY), CurrentScrollPosition, new Rect(Rect.x, Rect.y, WidthSize + 10, 50f + 45 * NumberOfButtons), false, true);
            for (int i = 0; i < Buttons.Count; i++)
            {
                Buttons[i].Draw();
            }
            GUI.EndScrollView();
        }

        private void SetBackground(int windowID)
        {
            GUI.Box(new Rect(0f, 0f, WidthSize + 10, 50f + 45 * NumberOfButtons), "", Styles.CornerStyle);
            if (Event.current.type == EventType.MouseDrag)
            {
                delay += Time.deltaTime;
                if (delay > 0.3f)
                {
                    IfDragged = true;
                }
            }
            else if (Event.current.type == EventType.MouseUp)
            {
                delay = 0;
                if (!IfDragged)
                {
                    Enabled = !Enabled;
                    UmbraMenu.GetCharacter();
                }
                IfDragged = false;
            }
            GUI.DragWindow();
        }
    }
}
