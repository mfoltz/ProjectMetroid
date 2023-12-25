// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ForceMarkLayoutsForRebuild
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class ForceMarkLayoutsForRebuild : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Mode;
    private static readonly IntPtr NativeFieldInfoPtr_DelayFrames;
    private static readonly IntPtr NativeFieldInfoPtr_Layouts;
    private static readonly IntPtr NativeFieldInfoPtr_EnabledFrame;
    private static readonly IntPtr NativeFieldInfoPtr__FirstEnable;
    private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_ShouldRebuild_Private_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_Rebuild_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    public unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ForceMarkLayoutsForRebuild.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261467, XrefRangeEnd = 1261481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ForceMarkLayoutsForRebuild.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261481, XrefRangeEnd = 1261482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ShouldRebuild()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ForceMarkLayoutsForRebuild.NativeMethodInfoPtr_ShouldRebuild_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261482, XrefRangeEnd = 1261495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Rebuild()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ForceMarkLayoutsForRebuild.NativeMethodInfoPtr_Rebuild_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261495, XrefRangeEnd = 1261496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ForceMarkLayoutsForRebuild()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForceMarkLayoutsForRebuild>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ForceMarkLayoutsForRebuild.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ForceMarkLayoutsForRebuild()
    {
      Il2CppClassPointerStore<ForceMarkLayoutsForRebuild>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ForceMarkLayoutsForRebuild));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForceMarkLayoutsForRebuild>.NativeClassPtr);
      ForceMarkLayoutsForRebuild.NativeFieldInfoPtr_Mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceMarkLayoutsForRebuild>.NativeClassPtr, nameof (Mode));
      ForceMarkLayoutsForRebuild.NativeFieldInfoPtr_DelayFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceMarkLayoutsForRebuild>.NativeClassPtr, nameof (DelayFrames));
      ForceMarkLayoutsForRebuild.NativeFieldInfoPtr_Layouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceMarkLayoutsForRebuild>.NativeClassPtr, nameof (Layouts));
      ForceMarkLayoutsForRebuild.NativeFieldInfoPtr_EnabledFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceMarkLayoutsForRebuild>.NativeClassPtr, nameof (EnabledFrame));
      ForceMarkLayoutsForRebuild.NativeFieldInfoPtr__FirstEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceMarkLayoutsForRebuild>.NativeClassPtr, nameof (_FirstEnable));
      ForceMarkLayoutsForRebuild.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceMarkLayoutsForRebuild>.NativeClassPtr, 100667284);
      ForceMarkLayoutsForRebuild.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceMarkLayoutsForRebuild>.NativeClassPtr, 100667285);
      ForceMarkLayoutsForRebuild.NativeMethodInfoPtr_ShouldRebuild_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceMarkLayoutsForRebuild>.NativeClassPtr, 100667286);
      ForceMarkLayoutsForRebuild.NativeMethodInfoPtr_Rebuild_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceMarkLayoutsForRebuild>.NativeClassPtr, 100667287);
      ForceMarkLayoutsForRebuild.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceMarkLayoutsForRebuild>.NativeClassPtr, 100667288);
    }

    public ForceMarkLayoutsForRebuild(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ForceMarkLayoutsForRebuild.ModeEnum Mode
    {
      get
      {
        return *(ForceMarkLayoutsForRebuild.ModeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForceMarkLayoutsForRebuild.NativeFieldInfoPtr_Mode));
      }
      [param: In] set
      {
        *(ForceMarkLayoutsForRebuild.ModeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForceMarkLayoutsForRebuild.NativeFieldInfoPtr_Mode)) = value;
      }
    }

    public unsafe int DelayFrames
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForceMarkLayoutsForRebuild.NativeFieldInfoPtr_DelayFrames));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForceMarkLayoutsForRebuild.NativeFieldInfoPtr_DelayFrames)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<RectTransform> Layouts
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForceMarkLayoutsForRebuild.NativeFieldInfoPtr_Layouts));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<RectTransform>) null : new Il2CppReferenceArray<RectTransform>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForceMarkLayoutsForRebuild.NativeFieldInfoPtr_Layouts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int EnabledFrame
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForceMarkLayoutsForRebuild.NativeFieldInfoPtr_EnabledFrame));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForceMarkLayoutsForRebuild.NativeFieldInfoPtr_EnabledFrame)) = value;
      }
    }

    public unsafe bool _FirstEnable
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForceMarkLayoutsForRebuild.NativeFieldInfoPtr__FirstEnable));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForceMarkLayoutsForRebuild.NativeFieldInfoPtr__FirstEnable)) = value;
      }
    }

    public enum ModeEnum
    {
      EveryFrame,
      OnEveryEnable,
      OnFirstEnable,
    }
  }
}
