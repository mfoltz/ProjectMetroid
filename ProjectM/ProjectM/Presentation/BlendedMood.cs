// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.BlendedMood
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.Rendering;

#nullable disable
namespace ProjectM.Presentation
{
  public class BlendedMood : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Components;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetDefaultProfile_Public_Void_VolumeStack_VolumeProfile_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyValuesFromComponent_Private_Static_Void_VolumeComponent_VolumeComponent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BlendProfiles_Public_Void_VolumeStack_List_1_VolumeComponent_Single_0;

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1112497, RefRangeEnd = 1112502, XrefRangeStart = 1112489, XrefRangeEnd = 1112497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BlendedMood()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlendedMood>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BlendedMood.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1112517, RefRangeEnd = 1112521, XrefRangeStart = 1112502, XrefRangeEnd = 1112517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BlendedMood.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1112539, RefRangeEnd = 1112543, XrefRangeStart = 1112521, XrefRangeEnd = 1112539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetDefaultProfile(VolumeStack stack, VolumeProfile profile)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stack);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) profile);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BlendedMood.NativeMethodInfoPtr_SetDefaultProfile_Public_Void_VolumeStack_VolumeProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1112558, RefRangeEnd = 1112559, XrefRangeStart = 1112543, XrefRangeEnd = 1112558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CopyValuesFromComponent(
      VolumeComponent sourceComponent,
      VolumeComponent destinationComponent)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceComponent);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) destinationComponent);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BlendedMood.NativeMethodInfoPtr_CopyValuesFromComponent_Private_Static_Void_VolumeComponent_VolumeComponent_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(13)]
    [CachedScanResults(RefRangeStart = 1112617, RefRangeEnd = 1112630, XrefRangeStart = 1112559, XrefRangeEnd = 1112617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BlendProfiles(
      VolumeStack stack,
      List<VolumeComponent> components,
      float interpFactor)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stack);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) components);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &interpFactor;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BlendedMood.NativeMethodInfoPtr_BlendProfiles_Public_Void_VolumeStack_List_1_VolumeComponent_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BlendedMood()
    {
      Il2CppClassPointerStore<BlendedMood>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation", nameof (BlendedMood));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlendedMood>.NativeClassPtr);
      BlendedMood.NativeFieldInfoPtr_Components = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendedMood>.NativeClassPtr, nameof (Components));
      BlendedMood.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendedMood>.NativeClassPtr, 100688077);
      BlendedMood.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendedMood>.NativeClassPtr, 100688078);
      BlendedMood.NativeMethodInfoPtr_SetDefaultProfile_Public_Void_VolumeStack_VolumeProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendedMood>.NativeClassPtr, 100688079);
      BlendedMood.NativeMethodInfoPtr_CopyValuesFromComponent_Private_Static_Void_VolumeComponent_VolumeComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendedMood>.NativeClassPtr, 100688080);
      BlendedMood.NativeMethodInfoPtr_BlendProfiles_Public_Void_VolumeStack_List_1_VolumeComponent_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendedMood>.NativeClassPtr, 100688081);
    }

    public BlendedMood(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<VolumeComponent> Components
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlendedMood.NativeFieldInfoPtr_Components));
        return pointer == System.IntPtr.Zero ? (List<VolumeComponent>) null : new List<VolumeComponent>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlendedMood.NativeFieldInfoPtr_Components), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
