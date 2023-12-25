// Decompiled with JetBrains decompiler
// Type: ProjectM.CharacterHUDEntryCollectionAuthoring
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.UI;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class CharacterHUDEntryCollectionAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_BaseUnitEntry;
    private static readonly IntPtr NativeFieldInfoPtr_BaseUnitNamedEntry;
    private static readonly IntPtr NativeFieldInfoPtr_BaseUnitShortEntry;
    private static readonly IntPtr NativeFieldInfoPtr_BloodTypeEntry;
    private static readonly IntPtr NativeFieldInfoPtr_BossUnitEntry;
    private static readonly IntPtr NativeFieldInfoPtr_CharacterEntry;
    private static readonly IntPtr NativeFieldInfoPtr_EliteUnitEntry;
    private static readonly IntPtr NativeFieldInfoPtr_EliteUnitNamedEntry;
    private static readonly IntPtr NativeFieldInfoPtr_VampireHunterEntry;
    private static readonly IntPtr NativeFieldInfoPtr_BaseUnitTraderEntry;
    private static readonly IntPtr NativeFieldInfoPtr_SiegeUnitEntry;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209511, XrefRangeEnd = 1209541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(CharacterHUDEntryCollectionAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CharacterHUDEntryCollectionAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterHUDEntryCollectionAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterHUDEntryCollectionAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CharacterHUDEntryCollectionAuthoring()
    {
      Il2CppClassPointerStore<CharacterHUDEntryCollectionAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM", nameof (CharacterHUDEntryCollectionAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHUDEntryCollectionAuthoring>.NativeClassPtr);
      CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_BaseUnitEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntryCollectionAuthoring>.NativeClassPtr, nameof (BaseUnitEntry));
      CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_BaseUnitNamedEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntryCollectionAuthoring>.NativeClassPtr, nameof (BaseUnitNamedEntry));
      CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_BaseUnitShortEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntryCollectionAuthoring>.NativeClassPtr, nameof (BaseUnitShortEntry));
      CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_BloodTypeEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntryCollectionAuthoring>.NativeClassPtr, nameof (BloodTypeEntry));
      CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_BossUnitEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntryCollectionAuthoring>.NativeClassPtr, nameof (BossUnitEntry));
      CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_CharacterEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntryCollectionAuthoring>.NativeClassPtr, nameof (CharacterEntry));
      CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_EliteUnitEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntryCollectionAuthoring>.NativeClassPtr, nameof (EliteUnitEntry));
      CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_EliteUnitNamedEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntryCollectionAuthoring>.NativeClassPtr, nameof (EliteUnitNamedEntry));
      CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_VampireHunterEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntryCollectionAuthoring>.NativeClassPtr, nameof (VampireHunterEntry));
      CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_BaseUnitTraderEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntryCollectionAuthoring>.NativeClassPtr, nameof (BaseUnitTraderEntry));
      CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_SiegeUnitEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntryCollectionAuthoring>.NativeClassPtr, nameof (SiegeUnitEntry));
      CharacterHUDEntryCollectionAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUDEntryCollectionAuthoring>.NativeClassPtr, 100663633);
      CharacterHUDEntryCollectionAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUDEntryCollectionAuthoring>.NativeClassPtr, 100663634);
    }

    public CharacterHUDEntryCollectionAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CharacterHUDEntry BaseUnitEntry
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_BaseUnitEntry));
        return pointer == IntPtr.Zero ? (CharacterHUDEntry) null : new CharacterHUDEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_BaseUnitEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterHUDEntry BaseUnitNamedEntry
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_BaseUnitNamedEntry));
        return pointer == IntPtr.Zero ? (CharacterHUDEntry) null : new CharacterHUDEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_BaseUnitNamedEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterHUDEntry BaseUnitShortEntry
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_BaseUnitShortEntry));
        return pointer == IntPtr.Zero ? (CharacterHUDEntry) null : new CharacterHUDEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_BaseUnitShortEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterHUDEntry BloodTypeEntry
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_BloodTypeEntry));
        return pointer == IntPtr.Zero ? (CharacterHUDEntry) null : new CharacterHUDEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_BloodTypeEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterHUDEntry BossUnitEntry
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_BossUnitEntry));
        return pointer == IntPtr.Zero ? (CharacterHUDEntry) null : new CharacterHUDEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_BossUnitEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterHUDEntry CharacterEntry
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_CharacterEntry));
        return pointer == IntPtr.Zero ? (CharacterHUDEntry) null : new CharacterHUDEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_CharacterEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterHUDEntry EliteUnitEntry
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_EliteUnitEntry));
        return pointer == IntPtr.Zero ? (CharacterHUDEntry) null : new CharacterHUDEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_EliteUnitEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterHUDEntry EliteUnitNamedEntry
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_EliteUnitNamedEntry));
        return pointer == IntPtr.Zero ? (CharacterHUDEntry) null : new CharacterHUDEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_EliteUnitNamedEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterHUDEntry VampireHunterEntry
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_VampireHunterEntry));
        return pointer == IntPtr.Zero ? (CharacterHUDEntry) null : new CharacterHUDEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_VampireHunterEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterHUDEntry BaseUnitTraderEntry
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_BaseUnitTraderEntry));
        return pointer == IntPtr.Zero ? (CharacterHUDEntry) null : new CharacterHUDEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_BaseUnitTraderEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterHUDEntry SiegeUnitEntry
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_SiegeUnitEntry));
        return pointer == IntPtr.Zero ? (CharacterHUDEntry) null : new CharacterHUDEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollectionAuthoring.NativeFieldInfoPtr_SiegeUnitEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
