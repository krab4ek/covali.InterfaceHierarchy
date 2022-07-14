namespace covali.InterfaceHierarchy
{
    internal interface IAdvanceDraw : IDrawable
    {
        void DrawInBoundingBox(int top, int left, int bottom, int right);
        void DrawUpsideDown();
    }
}
