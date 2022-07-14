using covali.InterfaceHierarchy;

Console.WriteLine("***** Simple interface Hierrachy\n");

BitmapImage myBitmap = new();
myBitmap.Draw();
myBitmap.DrawInBoundingBox(top: 10, left: 20, bottom: 30, right: 70);
myBitmap.DrawUpsideDown();

IAdvanceDraw iAdwDraw = myBitmap as IAdvanceDraw;
if (iAdwDraw != null)
{
    iAdwDraw.DrawUpsideDown();
}