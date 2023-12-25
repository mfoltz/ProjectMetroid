// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.AdditionalMaterialOutput
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Stunlock.Sequencer;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine.Rendering;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AdditionalMaterialOutput
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_SequenceEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaterialAssetIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShadowCastingMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_RendererMask;
    private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyNormalMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyBaseMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutputParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastFrameOutputIndex;
    [FieldOffset(0)]
    public Entity Entity;
    [FieldOffset(8)]
    public Entity SequenceEntity;
    [FieldOffset(16)]
    public int MaterialAssetIndex;
    [FieldOffset(20)]
    public ShadowCastingMode ShadowCastingMode;
    [FieldOffset(24)]
    public int RendererMask;
    [FieldOffset(28)]
    public int Importance;
    [FieldOffset(32)]
    public float StartTime;
    [FieldOffset(36)]
    public bool CopyNormalMap;
    [FieldOffset(37)]
    public bool CopyBaseMap;
    [FieldOffset(40)]
    public BlackboardParameterRuntime OutputParameter;
    [FieldOffset(44)]
    public int LastFrameOutputIndex;

    static AdditionalMaterialOutput()
    {
      Il2CppClassPointerStore<AdditionalMaterialOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (AdditionalMaterialOutput));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdditionalMaterialOutput>.NativeClassPtr);
      AdditionalMaterialOutput.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialOutput>.NativeClassPtr, nameof (Entity));
      AdditionalMaterialOutput.NativeFieldInfoPtr_SequenceEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialOutput>.NativeClassPtr, nameof (SequenceEntity));
      AdditionalMaterialOutput.NativeFieldInfoPtr_MaterialAssetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialOutput>.NativeClassPtr, nameof (MaterialAssetIndex));
      AdditionalMaterialOutput.NativeFieldInfoPtr_ShadowCastingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialOutput>.NativeClassPtr, nameof (ShadowCastingMode));
      AdditionalMaterialOutput.NativeFieldInfoPtr_RendererMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialOutput>.NativeClassPtr, nameof (RendererMask));
      AdditionalMaterialOutput.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialOutput>.NativeClassPtr, nameof (Importance));
      AdditionalMaterialOutput.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialOutput>.NativeClassPtr, nameof (StartTime));
      AdditionalMaterialOutput.NativeFieldInfoPtr_CopyNormalMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialOutput>.NativeClassPtr, nameof (CopyNormalMap));
      AdditionalMaterialOutput.NativeFieldInfoPtr_CopyBaseMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialOutput>.NativeClassPtr, nameof (CopyBaseMap));
      AdditionalMaterialOutput.NativeFieldInfoPtr_OutputParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialOutput>.NativeClassPtr, nameof (OutputParameter));
      AdditionalMaterialOutput.NativeFieldInfoPtr_LastFrameOutputIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialOutput>.NativeClassPtr, nameof (LastFrameOutputIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AdditionalMaterialOutput>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
