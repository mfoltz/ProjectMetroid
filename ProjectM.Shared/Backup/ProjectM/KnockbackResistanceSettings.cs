// Decompiled with JetBrains decompiler
// Type: ProjectM.KnockbackResistanceSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class KnockbackResistanceSettings : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RESOURCES_PATH;
    private static readonly System.IntPtr NativeFieldInfoPtr_ASSET_PATH;
    private static readonly System.IntPtr NativeFieldInfoPtr_KnockbackEntries;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetKnockbackResistance_Public_Boolean_KnockbackResistanceCategory_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 726739, RefRangeEnd = 726743, XrefRangeStart = 726734, XrefRangeEnd = 726739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetKnockbackResistance(
      KnockbackResistanceCategory knockbackResistanceCategory,
      out int knockbackResistanceIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) knockbackResistanceCategory));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref knockbackResistanceIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(KnockbackResistanceSettings.NativeMethodInfoPtr_TryGetKnockbackResistance_Public_Boolean_KnockbackResistanceCategory_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726743, XrefRangeEnd = 726751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe KnockbackResistanceSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KnockbackResistanceSettings>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(KnockbackResistanceSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static KnockbackResistanceSettings()
    {
      Il2CppClassPointerStore<KnockbackResistanceSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (KnockbackResistanceSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KnockbackResistanceSettings>.NativeClassPtr);
      KnockbackResistanceSettings.NativeFieldInfoPtr_RESOURCES_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackResistanceSettings>.NativeClassPtr, nameof (RESOURCES_PATH));
      KnockbackResistanceSettings.NativeFieldInfoPtr_ASSET_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackResistanceSettings>.NativeClassPtr, nameof (ASSET_PATH));
      KnockbackResistanceSettings.NativeFieldInfoPtr_KnockbackEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackResistanceSettings>.NativeClassPtr, nameof (KnockbackEntries));
      KnockbackResistanceSettings.NativeMethodInfoPtr_TryGetKnockbackResistance_Public_Boolean_KnockbackResistanceCategory_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnockbackResistanceSettings>.NativeClassPtr, 100664254);
      KnockbackResistanceSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnockbackResistanceSettings>.NativeClassPtr, 100664255);
    }

    public KnockbackResistanceSettings(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string RESOURCES_PATH
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(KnockbackResistanceSettings.NativeFieldInfoPtr_RESOURCES_PATH, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(KnockbackResistanceSettings.NativeFieldInfoPtr_RESOURCES_PATH, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string ASSET_PATH
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(KnockbackResistanceSettings.NativeFieldInfoPtr_ASSET_PATH, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(KnockbackResistanceSettings.NativeFieldInfoPtr_ASSET_PATH, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe List<KnockbackResistanceSettings.KnockbackEntry> KnockbackEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KnockbackResistanceSettings.NativeFieldInfoPtr_KnockbackEntries));
        return pointer == System.IntPtr.Zero ? (List<KnockbackResistanceSettings.KnockbackEntry>) null : new List<KnockbackResistanceSettings.KnockbackEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(KnockbackResistanceSettings.NativeFieldInfoPtr_KnockbackEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public sealed class KnockbackEntry : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Guid;
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;

      static KnockbackEntry()
      {
        Il2CppClassPointerStore<KnockbackResistanceSettings.KnockbackEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KnockbackResistanceSettings>.NativeClassPtr, nameof (KnockbackEntry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KnockbackResistanceSettings.KnockbackEntry>.NativeClassPtr);
        KnockbackResistanceSettings.KnockbackEntry.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackResistanceSettings.KnockbackEntry>.NativeClassPtr, nameof (Guid));
        KnockbackResistanceSettings.KnockbackEntry.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackResistanceSettings.KnockbackEntry>.NativeClassPtr, nameof (Name));
      }

      public KnockbackEntry(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public KnockbackEntry()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KnockbackResistanceSettings.KnockbackEntry>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KnockbackResistanceSettings.KnockbackEntry>.NativeClassPtr, data));
      }

      public unsafe string Guid
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KnockbackResistanceSettings.KnockbackEntry.NativeFieldInfoPtr_Guid)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(KnockbackResistanceSettings.KnockbackEntry.NativeFieldInfoPtr_Guid), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe string Name
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KnockbackResistanceSettings.KnockbackEntry.NativeFieldInfoPtr_Name)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(KnockbackResistanceSettings.KnockbackEntry.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }
    }
  }
}
