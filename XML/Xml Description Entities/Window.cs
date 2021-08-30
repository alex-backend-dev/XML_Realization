﻿namespace XML
{
    /// <summary>
    /// Wrapper for window description  
    /// </summary>
    public class Window
    {
        public string Title { get; set; }
        public int? Top { get; set; }
        public int? Left { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }

        /// <summary>
        /// Check correction of window title
        /// </summary>
        /// <returns> Correct elements </returns>
        public bool IsCorrectWindow()
        {
            return Title == "main" && Top != null && Left != null && Width != null && Height != null;
        }

        /// <summary>
        /// Reformate type
        /// </summary>
        /// <returns> Elements in string format </returns>
        public override string ToString()
        {
            return $"{Title}({Top},{Left},{Width},{Height})";
        }

        /// <summary>
        /// Initianilize properties when they are nullable
        /// </summary>
        public void SetProperties()
        {
            if (Top == null)
            {
                Top = 0;
            }

            if (Left == null)
            {
                Left = 0;
            }

            if (Width == null)
            {
                Width = 400;
            }

            if (Height == null)
            {
                Height = 150;
            }
        }
    }
}