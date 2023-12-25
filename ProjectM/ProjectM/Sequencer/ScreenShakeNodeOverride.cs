// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.ScreenShakeNodeOverride
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Sequencer
{
  [Serializable]
  public class ScreenShakeNodeOverride : SequenceNodeOverride
  {
    private static readonly IntPtr NativeFieldInfoPtr_GUID;
    private static readonly IntPtr NativeFieldInfoPtr_ScreenShakeComponent;
    private static readonly IntPtr NativeFieldInfoPtr_UseMinRange_Override;
    private static readonly IntPtr NativeFieldInfoPtr_MinRange_Override;
    private static readonly IntPtr NativeFieldInfoPtr_UseMaxRange_Override;
    private static readonly IntPtr NativeFieldInfoPtr_MaxRange_Override;
    private static readonly IntPtr NativeFieldInfoPtr_UseForce_Override;
    private static readonly IntPtr NativeFieldInfoPtr_Force_Override;
    private static readonly IntPtr NativeFieldInfoPtr_UseSideForce_Override;
    private static readonly IntPtr NativeFieldInfoPtr_SideForce_Override;
    private static readonly IntPtr NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddGameObjectReferences_Public_Virtual_Void_List_1_GameObject_0;
    private static readonly IntPtr NativeMethodInfoPtr_CreateNew_Public_Static_ScreenShakeNodeOverride_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_CreateDefault_Public_Static_ScreenShakeNodeOverride_0;
    private static readonly IntPtr NativeMethodInfoPtr_HasNodeAnyOverride_Protected_Virtual_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetDeterministicHash_Public_Virtual_Int32_Object_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public override unsafe int CurrentVersion
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 29193, RefRangeEnd = 29196, XrefRangeStart = 29193, XrefRangeEnd = 29196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ScreenShakeNodeOverride.NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void AddGameObjectReferences(List<GameObject> references)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) references);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ScreenShakeNodeOverride.NativeMethodInfoPtr_AddGameObjectReferences_Public_Virtual_Void_List_1_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094039, XrefRangeEnd = 1094045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ScreenShakeNodeOverride CreateNew(string nodeGuid)
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(nodeGuid);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScreenShakeNodeOverride.NativeMethodInfoPtr_CreateNew_Public_Static_ScreenShakeNodeOverride_String_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (ScreenShakeNodeOverride) null : new ScreenShakeNodeOverride(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094045, XrefRangeEnd = 1094053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ScreenShakeNodeOverride CreateDefault()
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScreenShakeNodeOverride.NativeMethodInfoPtr_CreateDefault_Public_Static_ScreenShakeNodeOverride_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (ScreenShakeNodeOverride) null : new ScreenShakeNodeOverride(pointer);
    }

    [CallerCount(0)]
    public override unsafe bool HasNodeAnyOverride()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ScreenShakeNodeOverride.NativeMethodInfoPtr_HasNodeAnyOverride_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094053, XrefRangeEnd = 1094061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetDeterministicHash(UnityEngine.Object sourceAsset)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceAsset);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ScreenShakeNodeOverride.NativeMethodInfoPtr_GetDeterministicHash_Public_Virtual_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ScreenShakeNodeOverride()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenShakeNodeOverride>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScreenShakeNodeOverride.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ScreenShakeNodeOverride()
    {
      Il2CppClassPointerStore<ScreenShakeNodeOverride>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (ScreenShakeNodeOverride));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenShakeNodeOverride>.NativeClassPtr);
      ScreenShakeNodeOverride.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeNodeOverride>.NativeClassPtr, nameof (GUID));
      ScreenShakeNodeOverride.NativeFieldInfoPtr_ScreenShakeComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeNodeOverride>.NativeClassPtr, nameof (ScreenShakeComponent));
      ScreenShakeNodeOverride.NativeFieldInfoPtr_UseMinRange_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeNodeOverride>.NativeClassPtr, nameof (UseMinRange_Override));
      ScreenShakeNodeOverride.NativeFieldInfoPtr_MinRange_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeNodeOverride>.NativeClassPtr, nameof (MinRange_Override));
      ScreenShakeNodeOverride.NativeFieldInfoPtr_UseMaxRange_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeNodeOverride>.NativeClassPtr, nameof (UseMaxRange_Override));
      ScreenShakeNodeOverride.NativeFieldInfoPtr_MaxRange_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeNodeOverride>.NativeClassPtr, nameof (MaxRange_Override));
      ScreenShakeNodeOverride.NativeFieldInfoPtr_UseForce_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeNodeOverride>.NativeClassPtr, nameof (UseForce_Override));
      ScreenShakeNodeOverride.NativeFieldInfoPtr_Force_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeNodeOverride>.NativeClassPtr, nameof (Force_Override));
      ScreenShakeNodeOverride.NativeFieldInfoPtr_UseSideForce_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeNodeOverride>.NativeClassPtr, nameof (UseSideForce_Override));
      ScreenShakeNodeOverride.NativeFieldInfoPtr_SideForce_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeNodeOverride>.NativeClassPtr, nameof (SideForce_Override));
      ScreenShakeNodeOverride.NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenShakeNodeOverride>.NativeClassPtr, 100686658);
      ScreenShakeNodeOverride.NativeMethodInfoPtr_AddGameObjectReferences_Public_Virtual_Void_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenShakeNodeOverride>.NativeClassPtr, 100686659);
      ScreenShakeNodeOverride.NativeMethodInfoPtr_CreateNew_Public_Static_ScreenShakeNodeOverride_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenShakeNodeOverride>.NativeClassPtr, 100686660);
      ScreenShakeNodeOverride.NativeMethodInfoPtr_CreateDefault_Public_Static_ScreenShakeNodeOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenShakeNodeOverride>.NativeClassPtr, 100686661);
      ScreenShakeNodeOverride.NativeMethodInfoPtr_HasNodeAnyOverride_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenShakeNodeOverride>.NativeClassPtr, 100686662);
      ScreenShakeNodeOverride.NativeMethodInfoPtr_GetDeterministicHash_Public_Virtual_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenShakeNodeOverride>.NativeClassPtr, 100686663);
      ScreenShakeNodeOverride.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenShakeNodeOverride>.NativeClassPtr, 100686664);
    }

    public ScreenShakeNodeOverride(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string GUID
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeNodeOverride.NativeFieldInfoPtr_GUID)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeNodeOverride.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe ScreenShakeComponent ScreenShakeComponent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeNodeOverride.NativeFieldInfoPtr_ScreenShakeComponent));
        return pointer == IntPtr.Zero ? (ScreenShakeComponent) null : new ScreenShakeComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeNodeOverride.NativeFieldInfoPtr_ScreenShakeComponent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool UseMinRange_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeNodeOverride.NativeFieldInfoPtr_UseMinRange_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeNodeOverride.NativeFieldInfoPtr_UseMinRange_Override)) = value;
      }
    }

    public unsafe float MinRange_Override
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeNodeOverride.NativeFieldInfoPtr_MinRange_Override));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeNodeOverride.NativeFieldInfoPtr_MinRange_Override)) = value;
      }
    }

    public unsafe bool UseMaxRange_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeNodeOverride.NativeFieldInfoPtr_UseMaxRange_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeNodeOverride.NativeFieldInfoPtr_UseMaxRange_Override)) = value;
      }
    }

    public unsafe float MaxRange_Override
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeNodeOverride.NativeFieldInfoPtr_MaxRange_Override));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeNodeOverride.NativeFieldInfoPtr_MaxRange_Override)) = value;
      }
    }

    public unsafe bool UseForce_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeNodeOverride.NativeFieldInfoPtr_UseForce_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeNodeOverride.NativeFieldInfoPtr_UseForce_Override)) = value;
      }
    }

    public unsafe float Force_Override
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeNodeOverride.NativeFieldInfoPtr_Force_Override));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeNodeOverride.NativeFieldInfoPtr_Force_Override)) = value;
      }
    }

    public unsafe bool UseSideForce_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeNodeOverride.NativeFieldInfoPtr_UseSideForce_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeNodeOverride.NativeFieldInfoPtr_UseSideForce_Override)) = value;
      }
    }

    public unsafe float SideForce_Override
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeNodeOverride.NativeFieldInfoPtr_SideForce_Override));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeNodeOverride.NativeFieldInfoPtr_SideForce_Override)) = value;
      }
    }
  }
}
