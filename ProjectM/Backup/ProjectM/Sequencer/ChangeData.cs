// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.ChangeData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ChangeData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Float4Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FloatValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_PropertyName;
    private static readonly System.IntPtr NativeFieldInfoPtr_PropertyType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Property;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseCustomProperty;
    private static readonly System.IntPtr NativeFieldInfoPtr_RendererMask;
    [FieldOffset(0)]
    public float4 Float4Value;
    [FieldOffset(16)]
    public float FloatValue;
    [FieldOffset(20)]
    public FixedString64 PropertyName;
    [FieldOffset(84)]
    public MaterialPropertyTypeEnum PropertyType;
    [FieldOffset(88)]
    public SupportedDotsProperty Property;
    [FieldOffset(92)]
    public bool UseCustomProperty;
    [FieldOffset(96)]
    public int RendererMask;

    static ChangeData()
    {
      Il2CppClassPointerStore<ChangeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (ChangeData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeData>.NativeClassPtr);
      ChangeData.NativeFieldInfoPtr_Float4Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeData>.NativeClassPtr, nameof (Float4Value));
      ChangeData.NativeFieldInfoPtr_FloatValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeData>.NativeClassPtr, nameof (FloatValue));
      ChangeData.NativeFieldInfoPtr_PropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeData>.NativeClassPtr, nameof (PropertyName));
      ChangeData.NativeFieldInfoPtr_PropertyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeData>.NativeClassPtr, nameof (PropertyType));
      ChangeData.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeData>.NativeClassPtr, nameof (Property));
      ChangeData.NativeFieldInfoPtr_UseCustomProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeData>.NativeClassPtr, nameof (UseCustomProperty));
      ChangeData.NativeFieldInfoPtr_RendererMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeData>.NativeClassPtr, nameof (RendererMask));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChangeData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
