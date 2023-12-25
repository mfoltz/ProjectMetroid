// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.AdditionalMaterialEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Stunlock.Sequencer;
using System.Runtime.InteropServices;
using UnityEngine.Rendering;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AdditionalMaterialEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NodeIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutputEntityParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_RendererMask;
    private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShadowCastingMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyNormalMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyBaseMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaterialAssetIndex;
    [FieldOffset(0)]
    public int NodeIndex;
    [FieldOffset(4)]
    public BlackboardParameterRuntime TargetParameter;
    [FieldOffset(8)]
    public BlackboardParameterRuntime OutputEntityParameter;
    [FieldOffset(12)]
    public int RendererMask;
    [FieldOffset(16)]
    public int Importance;
    [FieldOffset(20)]
    public ShadowCastingMode ShadowCastingMode;
    [FieldOffset(24)]
    public bool CopyNormalMap;
    [FieldOffset(25)]
    public bool CopyBaseMap;
    [FieldOffset(28)]
    public int MaterialAssetIndex;

    static AdditionalMaterialEvent()
    {
      Il2CppClassPointerStore<AdditionalMaterialEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (AdditionalMaterialEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdditionalMaterialEvent>.NativeClassPtr);
      AdditionalMaterialEvent.NativeFieldInfoPtr_NodeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialEvent>.NativeClassPtr, nameof (NodeIndex));
      AdditionalMaterialEvent.NativeFieldInfoPtr_TargetParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialEvent>.NativeClassPtr, nameof (TargetParameter));
      AdditionalMaterialEvent.NativeFieldInfoPtr_OutputEntityParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialEvent>.NativeClassPtr, nameof (OutputEntityParameter));
      AdditionalMaterialEvent.NativeFieldInfoPtr_RendererMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialEvent>.NativeClassPtr, nameof (RendererMask));
      AdditionalMaterialEvent.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialEvent>.NativeClassPtr, nameof (Importance));
      AdditionalMaterialEvent.NativeFieldInfoPtr_ShadowCastingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialEvent>.NativeClassPtr, nameof (ShadowCastingMode));
      AdditionalMaterialEvent.NativeFieldInfoPtr_CopyNormalMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialEvent>.NativeClassPtr, nameof (CopyNormalMap));
      AdditionalMaterialEvent.NativeFieldInfoPtr_CopyBaseMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialEvent>.NativeClassPtr, nameof (CopyBaseMap));
      AdditionalMaterialEvent.NativeFieldInfoPtr_MaterialAssetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialEvent>.NativeClassPtr, nameof (MaterialAssetIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AdditionalMaterialEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
