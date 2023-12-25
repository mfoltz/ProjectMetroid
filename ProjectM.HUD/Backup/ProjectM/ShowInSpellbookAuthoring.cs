// Decompiled with JetBrains decompiler
// Type: ProjectM.ShowInSpellbookAuthoring
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

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
  public class ShowInSpellbookAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_UseParentNameAndDescription;
    private static readonly IntPtr NativeFieldInfoPtr_Header;
    private static readonly IntPtr NativeFieldInfoPtr_DescriptionBuilder;
    private static readonly IntPtr NativeFieldInfoPtr_Icon;
    private static readonly IntPtr NativeFieldInfoPtr_DisplayLifetime;
    private static readonly IntPtr NativeFieldInfoPtr_HideLifetimeText;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209352, XrefRangeEnd = 1209372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(ShowInSpellbookAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209372, XrefRangeEnd = 1209378, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShowInSpellbookAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209378, XrefRangeEnd = 1209379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ShowInSpellbookAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowInSpellbookAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShowInSpellbookAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ShowInSpellbookAuthoring()
    {
      Il2CppClassPointerStore<ShowInSpellbookAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM", nameof (ShowInSpellbookAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowInSpellbookAuthoring>.NativeClassPtr);
      ShowInSpellbookAuthoring.NativeFieldInfoPtr_UseParentNameAndDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowInSpellbookAuthoring>.NativeClassPtr, nameof (UseParentNameAndDescription));
      ShowInSpellbookAuthoring.NativeFieldInfoPtr_Header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowInSpellbookAuthoring>.NativeClassPtr, nameof (Header));
      ShowInSpellbookAuthoring.NativeFieldInfoPtr_DescriptionBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowInSpellbookAuthoring>.NativeClassPtr, nameof (DescriptionBuilder));
      ShowInSpellbookAuthoring.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowInSpellbookAuthoring>.NativeClassPtr, nameof (Icon));
      ShowInSpellbookAuthoring.NativeFieldInfoPtr_DisplayLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowInSpellbookAuthoring>.NativeClassPtr, nameof (DisplayLifetime));
      ShowInSpellbookAuthoring.NativeFieldInfoPtr_HideLifetimeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowInSpellbookAuthoring>.NativeClassPtr, nameof (HideLifetimeText));
      ShowInSpellbookAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowInSpellbookAuthoring>.NativeClassPtr, 100663609);
      ShowInSpellbookAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowInSpellbookAuthoring>.NativeClassPtr, 100663610);
      ShowInSpellbookAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowInSpellbookAuthoring>.NativeClassPtr, 100663611);
    }

    public ShowInSpellbookAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool UseParentNameAndDescription
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowInSpellbookAuthoring.NativeFieldInfoPtr_UseParentNameAndDescription));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowInSpellbookAuthoring.NativeFieldInfoPtr_UseParentNameAndDescription)) = value;
      }
    }

    public unsafe LocalizationKey Header
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowInSpellbookAuthoring.NativeFieldInfoPtr_Header));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowInSpellbookAuthoring.NativeFieldInfoPtr_Header)) = value;
      }
    }

    public unsafe LocalizedStringBuilder DescriptionBuilder
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowInSpellbookAuthoring.NativeFieldInfoPtr_DescriptionBuilder));
        return pointer == IntPtr.Zero ? (LocalizedStringBuilder) null : new LocalizedStringBuilder(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShowInSpellbookAuthoring.NativeFieldInfoPtr_DescriptionBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Icon
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowInSpellbookAuthoring.NativeFieldInfoPtr_Icon));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShowInSpellbookAuthoring.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool DisplayLifetime
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowInSpellbookAuthoring.NativeFieldInfoPtr_DisplayLifetime));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowInSpellbookAuthoring.NativeFieldInfoPtr_DisplayLifetime)) = value;
      }
    }

    public unsafe bool HideLifetimeText
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowInSpellbookAuthoring.NativeFieldInfoPtr_HideLifetimeText));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowInSpellbookAuthoring.NativeFieldInfoPtr_HideLifetimeText)) = value;
      }
    }
  }
}
