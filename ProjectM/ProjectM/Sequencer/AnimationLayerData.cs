// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.AnimationLayerData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  [Serializable]
  public class AnimationLayerData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Layer;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlendInTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlendOutTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlendOutTimeIfRunning;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExitIfRunning;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AnimationLayerData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationLayerData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AnimationLayerData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AnimationLayerData()
    {
      Il2CppClassPointerStore<AnimationLayerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (AnimationLayerData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationLayerData>.NativeClassPtr);
      AnimationLayerData.NativeFieldInfoPtr_Layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationLayerData>.NativeClassPtr, nameof (Layer));
      AnimationLayerData.NativeFieldInfoPtr_BlendInTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationLayerData>.NativeClassPtr, nameof (BlendInTime));
      AnimationLayerData.NativeFieldInfoPtr_BlendOutTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationLayerData>.NativeClassPtr, nameof (BlendOutTime));
      AnimationLayerData.NativeFieldInfoPtr_BlendOutTimeIfRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationLayerData>.NativeClassPtr, nameof (BlendOutTimeIfRunning));
      AnimationLayerData.NativeFieldInfoPtr_ExitIfRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationLayerData>.NativeClassPtr, nameof (ExitIfRunning));
      AnimationLayerData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLayerData>.NativeClassPtr, 100685815);
    }

    public AnimationLayerData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe AnimationLayerEnum Layer
    {
      get
      {
        return *(AnimationLayerEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationLayerData.NativeFieldInfoPtr_Layer));
      }
      [param: In] set
      {
        *(AnimationLayerEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationLayerData.NativeFieldInfoPtr_Layer)) = value;
      }
    }

    public BlackboardParameterValue BlendInTime
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationLayerData.NativeFieldInfoPtr_BlendInTime);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationLayerData.NativeFieldInfoPtr_BlendInTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public BlackboardParameterValue BlendOutTime
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationLayerData.NativeFieldInfoPtr_BlendOutTime);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationLayerData.NativeFieldInfoPtr_BlendOutTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public BlackboardParameterValue BlendOutTimeIfRunning
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationLayerData.NativeFieldInfoPtr_BlendOutTimeIfRunning);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationLayerData.NativeFieldInfoPtr_BlendOutTimeIfRunning), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public BlackboardParameterValue ExitIfRunning
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationLayerData.NativeFieldInfoPtr_ExitIfRunning);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationLayerData.NativeFieldInfoPtr_ExitIfRunning), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
