// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.AnimationLayerData_Override
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
  public class AnimationLayerData_Override : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Layer;
    private static readonly System.IntPtr NativeFieldInfoPtr_Delete;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlendInTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlendOutTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExitIfRunning;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089837, XrefRangeEnd = 1089842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AnimationLayerData_Override.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AnimationLayerData_Override()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationLayerData_Override>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AnimationLayerData_Override.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AnimationLayerData_Override()
    {
      Il2CppClassPointerStore<AnimationLayerData_Override>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (AnimationLayerData_Override));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationLayerData_Override>.NativeClassPtr);
      AnimationLayerData_Override.NativeFieldInfoPtr_Layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationLayerData_Override>.NativeClassPtr, nameof (Layer));
      AnimationLayerData_Override.NativeFieldInfoPtr_Delete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationLayerData_Override>.NativeClassPtr, nameof (Delete));
      AnimationLayerData_Override.NativeFieldInfoPtr_BlendInTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationLayerData_Override>.NativeClassPtr, nameof (BlendInTime));
      AnimationLayerData_Override.NativeFieldInfoPtr_BlendOutTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationLayerData_Override>.NativeClassPtr, nameof (BlendOutTime));
      AnimationLayerData_Override.NativeFieldInfoPtr_ExitIfRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationLayerData_Override>.NativeClassPtr, nameof (ExitIfRunning));
      AnimationLayerData_Override.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLayerData_Override>.NativeClassPtr, 100685816);
      AnimationLayerData_Override.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLayerData_Override>.NativeClassPtr, 100685817);
    }

    public AnimationLayerData_Override(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe AnimationLayerEnum Layer
    {
      get
      {
        return *(AnimationLayerEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationLayerData_Override.NativeFieldInfoPtr_Layer));
      }
      [param: In] set
      {
        *(AnimationLayerEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationLayerData_Override.NativeFieldInfoPtr_Layer)) = value;
      }
    }

    public unsafe bool Delete
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationLayerData_Override.NativeFieldInfoPtr_Delete));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationLayerData_Override.NativeFieldInfoPtr_Delete)) = value;
      }
    }

    public unsafe float BlendInTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationLayerData_Override.NativeFieldInfoPtr_BlendInTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationLayerData_Override.NativeFieldInfoPtr_BlendInTime)) = value;
      }
    }

    public unsafe float BlendOutTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationLayerData_Override.NativeFieldInfoPtr_BlendOutTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationLayerData_Override.NativeFieldInfoPtr_BlendOutTime)) = value;
      }
    }

    public unsafe bool ExitIfRunning
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationLayerData_Override.NativeFieldInfoPtr_ExitIfRunning));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationLayerData_Override.NativeFieldInfoPtr_ExitIfRunning)) = value;
      }
    }
  }
}
