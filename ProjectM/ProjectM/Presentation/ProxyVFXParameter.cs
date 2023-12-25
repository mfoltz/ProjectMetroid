// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.ProxyVFXParameter
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Presentation
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ProxyVFXParameter
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ValueType;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_NameIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsValid;
    [FieldOffset(0)]
    public ProxyVFXValueType ValueType;
    [FieldOffset(4)]
    public ProxyVFXSocketValue OverrideValue;
    [FieldOffset(20)]
    public int NameIndex;
    [FieldOffset(24)]
    public bool IsValid;

    static ProxyVFXParameter()
    {
      Il2CppClassPointerStore<ProxyVFXParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation", nameof (ProxyVFXParameter));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProxyVFXParameter>.NativeClassPtr);
      ProxyVFXParameter.NativeFieldInfoPtr_ValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyVFXParameter>.NativeClassPtr, nameof (ValueType));
      ProxyVFXParameter.NativeFieldInfoPtr_OverrideValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyVFXParameter>.NativeClassPtr, nameof (OverrideValue));
      ProxyVFXParameter.NativeFieldInfoPtr_NameIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyVFXParameter>.NativeClassPtr, nameof (NameIndex));
      ProxyVFXParameter.NativeFieldInfoPtr_IsValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyVFXParameter>.NativeClassPtr, nameof (IsValid));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProxyVFXParameter>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
