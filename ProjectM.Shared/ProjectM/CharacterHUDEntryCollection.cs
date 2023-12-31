// Decompiled with JetBrains decompiler
// Type: ProjectM.CharacterHUDEntryCollection
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class CharacterHUDEntryCollection : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EntryTypeCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_CharacterEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr_BaseUnitEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr_BaseUnitNamedEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr_BaseUnitShortEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodTypeEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr_BossUnitEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr_EliteUnitEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr_EliteUnitNamedEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr_VampireHunterEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr_BaseUnitTraderEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr_SiegeUnitEntry;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCharacterHUD_Public_GameObject_CharacterHUDEntryType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsElite_Public_Static_Boolean_CharacterHUDEntryType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsVBlood_Public_Static_Boolean_CharacterHUDEntryType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(4981)]
    [CachedScanResults(RefRangeStart = 10610, RefRangeEnd = 15591, XrefRangeStart = 10610, XrefRangeEnd = 15591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Object System_ICloneable_Clone()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUDEntryCollection.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 723796, RefRangeEnd = 723797, XrefRangeStart = 723796, XrefRangeEnd = 723796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameObject GetCharacterHUD(CharacterHUDEntryType entryType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entryType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUDEntryCollection.NativeMethodInfoPtr_GetCharacterHUD_Public_GameObject_CharacterHUDEntryType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 723797, RefRangeEnd = 723798, XrefRangeStart = 723797, XrefRangeEnd = 723797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsElite(CharacterHUDEntryType entryType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entryType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUDEntryCollection.NativeMethodInfoPtr_IsElite_Public_Static_Boolean_CharacterHUDEntryType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 723798, RefRangeEnd = 723799, XrefRangeStart = 723798, XrefRangeEnd = 723798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsVBlood(CharacterHUDEntryType entryType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entryType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUDEntryCollection.NativeMethodInfoPtr_IsVBlood_Public_Static_Boolean_CharacterHUDEntryType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CharacterHUDEntryCollection()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterHUDEntryCollection>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterHUDEntryCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CharacterHUDEntryCollection()
    {
      Il2CppClassPointerStore<CharacterHUDEntryCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CharacterHUDEntryCollection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHUDEntryCollection>.NativeClassPtr);
      CharacterHUDEntryCollection.NativeFieldInfoPtr_EntryTypeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntryCollection>.NativeClassPtr, nameof (EntryTypeCount));
      CharacterHUDEntryCollection.NativeFieldInfoPtr_CharacterEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntryCollection>.NativeClassPtr, nameof (CharacterEntry));
      CharacterHUDEntryCollection.NativeFieldInfoPtr_BaseUnitEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntryCollection>.NativeClassPtr, nameof (BaseUnitEntry));
      CharacterHUDEntryCollection.NativeFieldInfoPtr_BaseUnitNamedEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntryCollection>.NativeClassPtr, nameof (BaseUnitNamedEntry));
      CharacterHUDEntryCollection.NativeFieldInfoPtr_BaseUnitShortEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntryCollection>.NativeClassPtr, nameof (BaseUnitShortEntry));
      CharacterHUDEntryCollection.NativeFieldInfoPtr_BloodTypeEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntryCollection>.NativeClassPtr, nameof (BloodTypeEntry));
      CharacterHUDEntryCollection.NativeFieldInfoPtr_BossUnitEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntryCollection>.NativeClassPtr, nameof (BossUnitEntry));
      CharacterHUDEntryCollection.NativeFieldInfoPtr_EliteUnitEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntryCollection>.NativeClassPtr, nameof (EliteUnitEntry));
      CharacterHUDEntryCollection.NativeFieldInfoPtr_EliteUnitNamedEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntryCollection>.NativeClassPtr, nameof (EliteUnitNamedEntry));
      CharacterHUDEntryCollection.NativeFieldInfoPtr_VampireHunterEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntryCollection>.NativeClassPtr, nameof (VampireHunterEntry));
      CharacterHUDEntryCollection.NativeFieldInfoPtr_BaseUnitTraderEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntryCollection>.NativeClassPtr, nameof (BaseUnitTraderEntry));
      CharacterHUDEntryCollection.NativeFieldInfoPtr_SiegeUnitEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDEntryCollection>.NativeClassPtr, nameof (SiegeUnitEntry));
      CharacterHUDEntryCollection.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUDEntryCollection>.NativeClassPtr, 100664000);
      CharacterHUDEntryCollection.NativeMethodInfoPtr_GetCharacterHUD_Public_GameObject_CharacterHUDEntryType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUDEntryCollection>.NativeClassPtr, 100664001);
      CharacterHUDEntryCollection.NativeMethodInfoPtr_IsElite_Public_Static_Boolean_CharacterHUDEntryType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUDEntryCollection>.NativeClassPtr, 100664002);
      CharacterHUDEntryCollection.NativeMethodInfoPtr_IsVBlood_Public_Static_Boolean_CharacterHUDEntryType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUDEntryCollection>.NativeClassPtr, 100664003);
      CharacterHUDEntryCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUDEntryCollection>.NativeClassPtr, 100664004);
    }

    public CharacterHUDEntryCollection(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int EntryTypeCount
    {
      get
      {
        int entryTypeCount;
        IL2CPP.il2cpp_field_static_get_value(CharacterHUDEntryCollection.NativeFieldInfoPtr_EntryTypeCount, (void*) &entryTypeCount);
        return entryTypeCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CharacterHUDEntryCollection.NativeFieldInfoPtr_EntryTypeCount, (void*) &value);
      }
    }

    public unsafe GameObject CharacterEntry
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollection.NativeFieldInfoPtr_CharacterEntry));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollection.NativeFieldInfoPtr_CharacterEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject BaseUnitEntry
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollection.NativeFieldInfoPtr_BaseUnitEntry));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollection.NativeFieldInfoPtr_BaseUnitEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject BaseUnitNamedEntry
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollection.NativeFieldInfoPtr_BaseUnitNamedEntry));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollection.NativeFieldInfoPtr_BaseUnitNamedEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject BaseUnitShortEntry
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollection.NativeFieldInfoPtr_BaseUnitShortEntry));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollection.NativeFieldInfoPtr_BaseUnitShortEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject BloodTypeEntry
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollection.NativeFieldInfoPtr_BloodTypeEntry));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollection.NativeFieldInfoPtr_BloodTypeEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject BossUnitEntry
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollection.NativeFieldInfoPtr_BossUnitEntry));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollection.NativeFieldInfoPtr_BossUnitEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject EliteUnitEntry
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollection.NativeFieldInfoPtr_EliteUnitEntry));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollection.NativeFieldInfoPtr_EliteUnitEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject EliteUnitNamedEntry
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollection.NativeFieldInfoPtr_EliteUnitNamedEntry));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollection.NativeFieldInfoPtr_EliteUnitNamedEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject VampireHunterEntry
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollection.NativeFieldInfoPtr_VampireHunterEntry));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollection.NativeFieldInfoPtr_VampireHunterEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject BaseUnitTraderEntry
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollection.NativeFieldInfoPtr_BaseUnitTraderEntry));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollection.NativeFieldInfoPtr_BaseUnitTraderEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject SiegeUnitEntry
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollection.NativeFieldInfoPtr_SiegeUnitEntry));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUDEntryCollection.NativeFieldInfoPtr_SiegeUnitEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
