// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.Trails.UVRect
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Presentation.Trails
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UVRect
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UStart;
    private static readonly System.IntPtr NativeFieldInfoPtr_UEnd;
    private static readonly System.IntPtr NativeFieldInfoPtr_VStart;
    private static readonly System.IntPtr NativeFieldInfoPtr_VEnd;
    [FieldOffset(0)]
    public float UStart;
    [FieldOffset(4)]
    public float UEnd;
    [FieldOffset(8)]
    public float VStart;
    [FieldOffset(12)]
    public float VEnd;

    static UVRect()
    {
      Il2CppClassPointerStore<UVRect>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation.Trails", nameof (UVRect));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UVRect>.NativeClassPtr);
      UVRect.NativeFieldInfoPtr_UStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UVRect>.NativeClassPtr, nameof (UStart));
      UVRect.NativeFieldInfoPtr_UEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UVRect>.NativeClassPtr, nameof (UEnd));
      UVRect.NativeFieldInfoPtr_VStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UVRect>.NativeClassPtr, nameof (VStart));
      UVRect.NativeFieldInfoPtr_VEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UVRect>.NativeClassPtr, nameof (VEnd));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UVRect>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
