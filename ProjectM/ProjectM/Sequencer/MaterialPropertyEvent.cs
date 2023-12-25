// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.MaterialPropertyEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Stunlock.Sequencer;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MaterialPropertyEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NodeIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_FloatParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_Float4Parameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaterialPropertyType;
    private static readonly System.IntPtr NativeFieldInfoPtr_RendererMask;
    private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseCustomProperty;
    private static readonly System.IntPtr NativeFieldInfoPtr_Property;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomProperty;
    [FieldOffset(0)]
    public int NodeIndex;
    [FieldOffset(4)]
    public BlackboardParameterRuntime TargetParameter;
    [FieldOffset(8)]
    public BlackboardParameterRuntime FloatParameter;
    [FieldOffset(12)]
    public BlackboardParameterRuntime Float4Parameter;
    [FieldOffset(16)]
    public MaterialPropertyTypeEnum MaterialPropertyType;
    [FieldOffset(20)]
    public int RendererMask;
    [FieldOffset(24)]
    public int Importance;
    [FieldOffset(28)]
    public bool UseCustomProperty;
    [FieldOffset(32)]
    public SupportedDotsProperty Property;
    [FieldOffset(36)]
    public FixedString64 CustomProperty;

    static MaterialPropertyEvent()
    {
      Il2CppClassPointerStore<MaterialPropertyEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (MaterialPropertyEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialPropertyEvent>.NativeClassPtr);
      MaterialPropertyEvent.NativeFieldInfoPtr_NodeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertyEvent>.NativeClassPtr, nameof (NodeIndex));
      MaterialPropertyEvent.NativeFieldInfoPtr_TargetParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertyEvent>.NativeClassPtr, nameof (TargetParameter));
      MaterialPropertyEvent.NativeFieldInfoPtr_FloatParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertyEvent>.NativeClassPtr, nameof (FloatParameter));
      MaterialPropertyEvent.NativeFieldInfoPtr_Float4Parameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertyEvent>.NativeClassPtr, nameof (Float4Parameter));
      MaterialPropertyEvent.NativeFieldInfoPtr_MaterialPropertyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertyEvent>.NativeClassPtr, nameof (MaterialPropertyType));
      MaterialPropertyEvent.NativeFieldInfoPtr_RendererMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertyEvent>.NativeClassPtr, nameof (RendererMask));
      MaterialPropertyEvent.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertyEvent>.NativeClassPtr, nameof (Importance));
      MaterialPropertyEvent.NativeFieldInfoPtr_UseCustomProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertyEvent>.NativeClassPtr, nameof (UseCustomProperty));
      MaterialPropertyEvent.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertyEvent>.NativeClassPtr, nameof (Property));
      MaterialPropertyEvent.NativeFieldInfoPtr_CustomProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertyEvent>.NativeClassPtr, nameof (CustomProperty));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MaterialPropertyEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
