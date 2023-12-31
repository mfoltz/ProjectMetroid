// Decompiled with JetBrains decompiler
// Type: ProjectM.TileHeightData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TileHeightData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Height;
    [FieldOffset(0)]
    public float Height;

    static TileHeightData()
    {
      Il2CppClassPointerStore<TileHeightData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TileHeightData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileHeightData>.NativeClassPtr);
      TileHeightData.NativeFieldInfoPtr_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightData>.NativeClassPtr, nameof (Height));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileHeightData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
