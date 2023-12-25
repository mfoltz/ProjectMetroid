// Decompiled with JetBrains decompiler
// Type: ProjectM.UseWaypointComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.UI;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class UseWaypointComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_ToFewPortalUnlocked;
    private static readonly IntPtr NativeFieldInfoPtr_TeleportBoundItemText;
    private static readonly IntPtr NativeFieldInfoPtr_HasCharmedUnitText;
    private static readonly IntPtr NativeFieldInfoPtr_TeleportBoundItemSctType;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012463, XrefRangeEnd = 1012470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UseWaypointComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UseWaypointComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UseWaypointComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UseWaypointComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UseWaypointComponent()
    {
      Il2CppClassPointerStore<UseWaypointComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (UseWaypointComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UseWaypointComponent>.NativeClassPtr);
      UseWaypointComponent.NativeFieldInfoPtr_ToFewPortalUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseWaypointComponent>.NativeClassPtr, nameof (ToFewPortalUnlocked));
      UseWaypointComponent.NativeFieldInfoPtr_TeleportBoundItemText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseWaypointComponent>.NativeClassPtr, nameof (TeleportBoundItemText));
      UseWaypointComponent.NativeFieldInfoPtr_HasCharmedUnitText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseWaypointComponent>.NativeClassPtr, nameof (HasCharmedUnitText));
      UseWaypointComponent.NativeFieldInfoPtr_TeleportBoundItemSctType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseWaypointComponent>.NativeClassPtr, nameof (TeleportBoundItemSctType));
      UseWaypointComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseWaypointComponent>.NativeClassPtr, 100678878);
      UseWaypointComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseWaypointComponent>.NativeClassPtr, 100678879);
    }

    public UseWaypointComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizationKey ToFewPortalUnlocked
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseWaypointComponent.NativeFieldInfoPtr_ToFewPortalUnlocked));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseWaypointComponent.NativeFieldInfoPtr_ToFewPortalUnlocked)) = value;
      }
    }

    public unsafe LocalizationKey TeleportBoundItemText
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseWaypointComponent.NativeFieldInfoPtr_TeleportBoundItemText));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseWaypointComponent.NativeFieldInfoPtr_TeleportBoundItemText)) = value;
      }
    }

    public unsafe LocalizationKey HasCharmedUnitText
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseWaypointComponent.NativeFieldInfoPtr_HasCharmedUnitText));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseWaypointComponent.NativeFieldInfoPtr_HasCharmedUnitText)) = value;
      }
    }

    public unsafe SCT_Type TeleportBoundItemSctType
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseWaypointComponent.NativeFieldInfoPtr_TeleportBoundItemSctType));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UseWaypointComponent.NativeFieldInfoPtr_TeleportBoundItemSctType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
