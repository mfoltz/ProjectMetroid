// Decompiled with JetBrains decompiler
// Type: ProjectM.JewelChanged
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct JewelChanged
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OldJewel;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewJewel;
    [FieldOffset(0)]
    public Entity OldJewel;
    [FieldOffset(8)]
    public Entity NewJewel;

    static JewelChanged()
    {
      Il2CppClassPointerStore<JewelChanged>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (JewelChanged));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JewelChanged>.NativeClassPtr);
      JewelChanged.NativeFieldInfoPtr_OldJewel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelChanged>.NativeClassPtr, nameof (OldJewel));
      JewelChanged.NativeFieldInfoPtr_NewJewel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelChanged>.NativeClassPtr, nameof (NewJewel));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JewelChanged>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
