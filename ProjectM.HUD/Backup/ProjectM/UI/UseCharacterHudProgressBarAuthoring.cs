// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.UseCharacterHudProgressBarAuthoring
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class UseCharacterHudProgressBarAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_ShowOn;
    private static readonly IntPtr NativeFieldInfoPtr_ShowFilter;
    private static readonly IntPtr NativeFieldInfoPtr_Importance;
    private static readonly IntPtr NativeFieldInfoPtr_Color;
    private static readonly IntPtr NativeFieldInfoPtr_Name;
    private static readonly IntPtr NativeFieldInfoPtr_Reverse;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1289323, XrefRangeEnd = 1289343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(UseCharacterHudProgressBarAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1289343, XrefRangeEnd = 1289350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UseCharacterHudProgressBarAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1289350, XrefRangeEnd = 1289352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UseCharacterHudProgressBarAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UseCharacterHudProgressBarAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UseCharacterHudProgressBarAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UseCharacterHudProgressBarAuthoring()
    {
      Il2CppClassPointerStore<UseCharacterHudProgressBarAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (UseCharacterHudProgressBarAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UseCharacterHudProgressBarAuthoring>.NativeClassPtr);
      UseCharacterHudProgressBarAuthoring.NativeFieldInfoPtr_ShowOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseCharacterHudProgressBarAuthoring>.NativeClassPtr, nameof (ShowOn));
      UseCharacterHudProgressBarAuthoring.NativeFieldInfoPtr_ShowFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseCharacterHudProgressBarAuthoring>.NativeClassPtr, nameof (ShowFilter));
      UseCharacterHudProgressBarAuthoring.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseCharacterHudProgressBarAuthoring>.NativeClassPtr, nameof (Importance));
      UseCharacterHudProgressBarAuthoring.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseCharacterHudProgressBarAuthoring>.NativeClassPtr, nameof (Color));
      UseCharacterHudProgressBarAuthoring.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseCharacterHudProgressBarAuthoring>.NativeClassPtr, nameof (Name));
      UseCharacterHudProgressBarAuthoring.NativeFieldInfoPtr_Reverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseCharacterHudProgressBarAuthoring>.NativeClassPtr, nameof (Reverse));
      UseCharacterHudProgressBarAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseCharacterHudProgressBarAuthoring>.NativeClassPtr, 100669757);
      UseCharacterHudProgressBarAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseCharacterHudProgressBarAuthoring>.NativeClassPtr, 100669758);
      UseCharacterHudProgressBarAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseCharacterHudProgressBarAuthoring>.NativeClassPtr, 100669759);
    }

    public UseCharacterHudProgressBarAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe HudShowOn ShowOn
    {
      get
      {
        return *(HudShowOn*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseCharacterHudProgressBarAuthoring.NativeFieldInfoPtr_ShowOn));
      }
      [param: In] set
      {
        *(HudShowOn*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseCharacterHudProgressBarAuthoring.NativeFieldInfoPtr_ShowOn)) = value;
      }
    }

    public unsafe HudShowFilter ShowFilter
    {
      get
      {
        return *(HudShowFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseCharacterHudProgressBarAuthoring.NativeFieldInfoPtr_ShowFilter));
      }
      [param: In] set
      {
        *(HudShowFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseCharacterHudProgressBarAuthoring.NativeFieldInfoPtr_ShowFilter)) = value;
      }
    }

    public unsafe Importance Importance
    {
      get
      {
        return *(Importance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseCharacterHudProgressBarAuthoring.NativeFieldInfoPtr_Importance));
      }
      [param: In] set
      {
        *(Importance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseCharacterHudProgressBarAuthoring.NativeFieldInfoPtr_Importance)) = value;
      }
    }

    public unsafe Color Color
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseCharacterHudProgressBarAuthoring.NativeFieldInfoPtr_Color));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseCharacterHudProgressBarAuthoring.NativeFieldInfoPtr_Color)) = value;
      }
    }

    public unsafe LocalizationKey Name
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseCharacterHudProgressBarAuthoring.NativeFieldInfoPtr_Name));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseCharacterHudProgressBarAuthoring.NativeFieldInfoPtr_Name)) = value;
      }
    }

    public unsafe bool Reverse
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseCharacterHudProgressBarAuthoring.NativeFieldInfoPtr_Reverse));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseCharacterHudProgressBarAuthoring.NativeFieldInfoPtr_Reverse)) = value;
      }
    }
  }
}
