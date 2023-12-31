// Decompiled with JetBrains decompiler
// Type: ProjectM.SyncedCollection
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class SyncedCollection : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__included;
    private static readonly System.IntPtr NativeFieldInfoPtr__excluded;
    private static readonly System.IntPtr NativeFieldInfoPtr__simulated;
    private static readonly System.IntPtr NativeFieldInfoPtr__includedTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr__excludedTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr__simulatedTypes;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSimulated_Public_IReadOnlyList_1_SyncedComponent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetIncluded_Public_IReadOnlyList_1_SyncedComponent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetExcluded_Public_IReadOnlyList_1_SyncedComponent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Include_Public_Void_StunlockBehaviour_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WillBeSimulated_Public_Void_StunlockBehaviour_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Exclude_Public_Void_StunlockBehaviour_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateSyncedComponent_Private_SyncedComponent_StunlockBehaviour_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ContainsComponent_Public_Boolean_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToCombinedList_Public_List_1_SyncedComponent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToCombinedTypeHashSet_Public_Void_HashSet_1_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSnapshotIdentifier_Public_NetworkSnapshotIdentifier_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    public unsafe IReadOnlyList<SyncedComponent> GetSimulated()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncedCollection.NativeMethodInfoPtr_GetSimulated_Public_IReadOnlyList_1_SyncedComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IReadOnlyList<SyncedComponent>) null : new IReadOnlyList<SyncedComponent>(pointer);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IReadOnlyList<SyncedComponent> GetIncluded()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncedCollection.NativeMethodInfoPtr_GetIncluded_Public_IReadOnlyList_1_SyncedComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IReadOnlyList<SyncedComponent>) null : new IReadOnlyList<SyncedComponent>(pointer);
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IReadOnlyList<SyncedComponent> GetExcluded()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncedCollection.NativeMethodInfoPtr_GetExcluded_Public_IReadOnlyList_1_SyncedComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IReadOnlyList<SyncedComponent>) null : new IReadOnlyList<SyncedComponent>(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 730733, RefRangeEnd = 730734, XrefRangeStart = 729298, XrefRangeEnd = 730733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Include<T>(StunlockBehaviour componentSource)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSource);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncedCollection.MethodInfoStoreGeneric_Include_Public_Void_StunlockBehaviour_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 730783, RefRangeEnd = 730785, XrefRangeStart = 730734, XrefRangeEnd = 730783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void WillBeSimulated<T>(StunlockBehaviour componentSource)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSource);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncedCollection.MethodInfoStoreGeneric_WillBeSimulated_Public_Void_StunlockBehaviour_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730785, XrefRangeEnd = 730799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Exclude<T>(StunlockBehaviour componentSource)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSource);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncedCollection.MethodInfoStoreGeneric_Exclude_Public_Void_StunlockBehaviour_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730799, XrefRangeEnd = 730806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SyncedComponent CreateSyncedComponent<T>(StunlockBehaviour component)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) component);
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SyncedCollection.MethodInfoStoreGeneric_CreateSyncedComponent_Private_SyncedComponent_StunlockBehaviour_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new SyncedComponent(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 730813, RefRangeEnd = 730814, XrefRangeStart = 730806, XrefRangeEnd = 730813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ContainsComponent(Il2CppSystem.Type type)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncedCollection.NativeMethodInfoPtr_ContainsComponent_Public_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730814, XrefRangeEnd = 730837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe List<SyncedComponent> ToCombinedList()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncedCollection.NativeMethodInfoPtr_ToCombinedList_Public_List_1_SyncedComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<SyncedComponent>) null : new List<SyncedComponent>(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730837, XrefRangeEnd = 730846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ToCombinedTypeHashSet(HashSet<Il2CppSystem.Type> hashSet)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hashSet);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncedCollection.NativeMethodInfoPtr_ToCombinedTypeHashSet_Public_Void_HashSet_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 730903, RefRangeEnd = 730904, XrefRangeStart = 730846, XrefRangeEnd = 730903, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NetworkSnapshotIdentifier GetSnapshotIdentifier()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncedCollection.NativeMethodInfoPtr_GetSnapshotIdentifier_Public_NetworkSnapshotIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (NetworkSnapshotIdentifier) null : new NetworkSnapshotIdentifier(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 730939, RefRangeEnd = 730940, XrefRangeStart = 730904, XrefRangeEnd = 730939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SyncedCollection()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyncedCollection>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncedCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SyncedCollection()
    {
      Il2CppClassPointerStore<SyncedCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SyncedCollection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncedCollection>.NativeClassPtr);
      SyncedCollection.NativeFieldInfoPtr__included = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedCollection>.NativeClassPtr, nameof (_included));
      SyncedCollection.NativeFieldInfoPtr__excluded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedCollection>.NativeClassPtr, nameof (_excluded));
      SyncedCollection.NativeFieldInfoPtr__simulated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedCollection>.NativeClassPtr, nameof (_simulated));
      SyncedCollection.NativeFieldInfoPtr__includedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedCollection>.NativeClassPtr, nameof (_includedTypes));
      SyncedCollection.NativeFieldInfoPtr__excludedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedCollection>.NativeClassPtr, nameof (_excludedTypes));
      SyncedCollection.NativeFieldInfoPtr__simulatedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedCollection>.NativeClassPtr, nameof (_simulatedTypes));
      SyncedCollection.NativeMethodInfoPtr_GetSimulated_Public_IReadOnlyList_1_SyncedComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedCollection>.NativeClassPtr, 100664581);
      SyncedCollection.NativeMethodInfoPtr_GetIncluded_Public_IReadOnlyList_1_SyncedComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedCollection>.NativeClassPtr, 100664582);
      SyncedCollection.NativeMethodInfoPtr_GetExcluded_Public_IReadOnlyList_1_SyncedComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedCollection>.NativeClassPtr, 100664583);
      SyncedCollection.NativeMethodInfoPtr_Include_Public_Void_StunlockBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedCollection>.NativeClassPtr, 100664584);
      SyncedCollection.NativeMethodInfoPtr_WillBeSimulated_Public_Void_StunlockBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedCollection>.NativeClassPtr, 100664585);
      SyncedCollection.NativeMethodInfoPtr_Exclude_Public_Void_StunlockBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedCollection>.NativeClassPtr, 100664586);
      SyncedCollection.NativeMethodInfoPtr_CreateSyncedComponent_Private_SyncedComponent_StunlockBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedCollection>.NativeClassPtr, 100664587);
      SyncedCollection.NativeMethodInfoPtr_ContainsComponent_Public_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedCollection>.NativeClassPtr, 100664588);
      SyncedCollection.NativeMethodInfoPtr_ToCombinedList_Public_List_1_SyncedComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedCollection>.NativeClassPtr, 100664589);
      SyncedCollection.NativeMethodInfoPtr_ToCombinedTypeHashSet_Public_Void_HashSet_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedCollection>.NativeClassPtr, 100664590);
      SyncedCollection.NativeMethodInfoPtr_GetSnapshotIdentifier_Public_NetworkSnapshotIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedCollection>.NativeClassPtr, 100664591);
      SyncedCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedCollection>.NativeClassPtr, 100664592);
    }

    public SyncedCollection(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<SyncedComponent> _included
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncedCollection.NativeFieldInfoPtr__included));
        return pointer == System.IntPtr.Zero ? (List<SyncedComponent>) null : new List<SyncedComponent>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SyncedCollection.NativeFieldInfoPtr__included), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SyncedComponent> _excluded
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncedCollection.NativeFieldInfoPtr__excluded));
        return pointer == System.IntPtr.Zero ? (List<SyncedComponent>) null : new List<SyncedComponent>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SyncedCollection.NativeFieldInfoPtr__excluded), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SyncedComponent> _simulated
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncedCollection.NativeFieldInfoPtr__simulated));
        return pointer == System.IntPtr.Zero ? (List<SyncedComponent>) null : new List<SyncedComponent>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SyncedCollection.NativeFieldInfoPtr__simulated), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HashSet<Il2CppSystem.Type> _includedTypes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncedCollection.NativeFieldInfoPtr__includedTypes));
        return pointer == System.IntPtr.Zero ? (HashSet<Il2CppSystem.Type>) null : new HashSet<Il2CppSystem.Type>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SyncedCollection.NativeFieldInfoPtr__includedTypes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HashSet<Il2CppSystem.Type> _excludedTypes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncedCollection.NativeFieldInfoPtr__excludedTypes));
        return pointer == System.IntPtr.Zero ? (HashSet<Il2CppSystem.Type>) null : new HashSet<Il2CppSystem.Type>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SyncedCollection.NativeFieldInfoPtr__excludedTypes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HashSet<Il2CppSystem.Type> _simulatedTypes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncedCollection.NativeFieldInfoPtr__simulatedTypes));
        return pointer == System.IntPtr.Zero ? (HashSet<Il2CppSystem.Type>) null : new HashSet<Il2CppSystem.Type>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SyncedCollection.NativeFieldInfoPtr__simulatedTypes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.SyncedCollection/<>c__DisplayClass14_0")]
    public sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_allRemoved;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ToCombinedList_b__0_Internal_Boolean_SyncedComponent_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass14_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyncedCollection.__c__DisplayClass14_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SyncedCollection.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729274, XrefRangeEnd = 729290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _ToCombinedList_b__0(SyncedComponent included)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) included));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncedCollection.__c__DisplayClass14_0.NativeMethodInfoPtr__ToCombinedList_b__0_Internal_Boolean_SyncedComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c__DisplayClass14_0()
      {
        Il2CppClassPointerStore<SyncedCollection.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SyncedCollection>.NativeClassPtr, "<>c__DisplayClass14_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncedCollection.__c__DisplayClass14_0>.NativeClassPtr);
        SyncedCollection.__c__DisplayClass14_0.NativeFieldInfoPtr_allRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedCollection.__c__DisplayClass14_0>.NativeClassPtr, nameof (allRemoved));
        SyncedCollection.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedCollection.__c__DisplayClass14_0>.NativeClassPtr, 100664593);
        SyncedCollection.__c__DisplayClass14_0.NativeMethodInfoPtr__ToCombinedList_b__0_Internal_Boolean_SyncedComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedCollection.__c__DisplayClass14_0>.NativeClassPtr, 100664594);
      }

      public __c__DisplayClass14_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe IEnumerable<SyncedComponent> allRemoved
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncedCollection.__c__DisplayClass14_0.NativeFieldInfoPtr_allRemoved));
          return pointer == System.IntPtr.Zero ? (IEnumerable<SyncedComponent>) null : new IEnumerable<SyncedComponent>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SyncedCollection.__c__DisplayClass14_0.NativeFieldInfoPtr_allRemoved), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.SyncedCollection/<>c__DisplayClass14_1")]
    public sealed class __c__DisplayClass14_1 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_included;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ToCombinedList_b__1_Internal_Boolean_SyncedComponent_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass14_1()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyncedCollection.__c__DisplayClass14_1>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SyncedCollection.__c__DisplayClass14_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729290, XrefRangeEnd = 729294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _ToCombinedList_b__1(SyncedComponent removed)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) removed));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncedCollection.__c__DisplayClass14_1.NativeMethodInfoPtr__ToCombinedList_b__1_Internal_Boolean_SyncedComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c__DisplayClass14_1()
      {
        Il2CppClassPointerStore<SyncedCollection.__c__DisplayClass14_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SyncedCollection>.NativeClassPtr, "<>c__DisplayClass14_1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncedCollection.__c__DisplayClass14_1>.NativeClassPtr);
        SyncedCollection.__c__DisplayClass14_1.NativeFieldInfoPtr_included = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedCollection.__c__DisplayClass14_1>.NativeClassPtr, nameof (included));
        SyncedCollection.__c__DisplayClass14_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedCollection.__c__DisplayClass14_1>.NativeClassPtr, 100664595);
        SyncedCollection.__c__DisplayClass14_1.NativeMethodInfoPtr__ToCombinedList_b__1_Internal_Boolean_SyncedComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedCollection.__c__DisplayClass14_1>.NativeClassPtr, 100664596);
      }

      public __c__DisplayClass14_1(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public SyncedComponent included
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncedCollection.__c__DisplayClass14_1.NativeFieldInfoPtr_included);
          return new SyncedComponent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SyncedComponent>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncedCollection.__c__DisplayClass14_1.NativeFieldInfoPtr_included), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SyncedComponent>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.SyncedCollection/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__16_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__16_1;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__GetSnapshotIdentifier_b__16_0_Internal_String_Type_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__GetSnapshotIdentifier_b__16_1_Internal_String_Type_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyncedCollection.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SyncedCollection.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _GetSnapshotIdentifier_b__16_0(Il2CppSystem.Type x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SyncedCollection.__c.NativeMethodInfoPtr__GetSnapshotIdentifier_b__16_0_Internal_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729294, XrefRangeEnd = 729298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _GetSnapshotIdentifier_b__16_1(Il2CppSystem.Type x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SyncedCollection.__c.NativeMethodInfoPtr__GetSnapshotIdentifier_b__16_1_Internal_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static __c()
      {
        Il2CppClassPointerStore<SyncedCollection.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SyncedCollection>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncedCollection.__c>.NativeClassPtr);
        SyncedCollection.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedCollection.__c>.NativeClassPtr, "<>9");
        SyncedCollection.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedCollection.__c>.NativeClassPtr, "<>9__16_0");
        SyncedCollection.__c.NativeFieldInfoPtr___9__16_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedCollection.__c>.NativeClassPtr, "<>9__16_1");
        SyncedCollection.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedCollection.__c>.NativeClassPtr, 100664598);
        SyncedCollection.__c.NativeMethodInfoPtr__GetSnapshotIdentifier_b__16_0_Internal_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedCollection.__c>.NativeClassPtr, 100664599);
        SyncedCollection.__c.NativeMethodInfoPtr__GetSnapshotIdentifier_b__16_1_Internal_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedCollection.__c>.NativeClassPtr, 100664600);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe SyncedCollection.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SyncedCollection.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (SyncedCollection.__c) null : new SyncedCollection.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SyncedCollection.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<Il2CppSystem.Type, string> __9__16_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SyncedCollection.__c.NativeFieldInfoPtr___9__16_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Il2CppSystem.Type, string>) null : new Il2CppSystem.Func<Il2CppSystem.Type, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SyncedCollection.__c.NativeFieldInfoPtr___9__16_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<Il2CppSystem.Type, string> __9__16_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SyncedCollection.__c.NativeFieldInfoPtr___9__16_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Il2CppSystem.Type, string>) null : new Il2CppSystem.Func<Il2CppSystem.Type, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SyncedCollection.__c.NativeFieldInfoPtr___9__16_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    private sealed class MethodInfoStoreGeneric_Include_Public_Void_StunlockBehaviour_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SyncedCollection.NativeMethodInfoPtr_Include_Public_Void_StunlockBehaviour_0, Il2CppClassPointerStore<SyncedCollection>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_WillBeSimulated_Public_Void_StunlockBehaviour_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SyncedCollection.NativeMethodInfoPtr_WillBeSimulated_Public_Void_StunlockBehaviour_0, Il2CppClassPointerStore<SyncedCollection>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Exclude_Public_Void_StunlockBehaviour_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SyncedCollection.NativeMethodInfoPtr_Exclude_Public_Void_StunlockBehaviour_0, Il2CppClassPointerStore<SyncedCollection>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_CreateSyncedComponent_Private_SyncedComponent_StunlockBehaviour_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SyncedCollection.NativeMethodInfoPtr_CreateSyncedComponent_Private_SyncedComponent_StunlockBehaviour_0, Il2CppClassPointerStore<SyncedCollection>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
