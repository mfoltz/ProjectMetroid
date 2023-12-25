// Decompiled with JetBrains decompiler
// Type: ProjectM.Compatibility.PersistenceCompatibilityChecker
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Compatibility
{
  public class PersistenceCompatibilityChecker : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ActiveObjects;
    private static readonly System.IntPtr NativeFieldInfoPtr__Result;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetResult_Public_PersistenceCompatibilityResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CompatibilityIssue_Public_Void_PersistenceIssueType_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckCanLoadFromSave_Public_Void_T_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckChildArrayCompatibility_Public_Void_String_Il2CppArrayBase_1_TEntry_Il2CppArrayBase_1_TEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckChildDictionaryCompatibility_Public_Void_String_Dictionary_2_TKey_TEntry_Dictionary_2_TKey_TEntry_PersistenceIssueType_PersistenceIssueType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckHashSetCompatibility_Public_Void_String_HashSet_1_TValue_HashSet_1_TValue_PersistenceIssueType_PersistenceIssueType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PersistenceCompatibilityResult GetResult()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityChecker.NativeMethodInfoPtr_GetResult_Public_PersistenceCompatibilityResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (PersistenceCompatibilityResult) null : new PersistenceCompatibilityResult(pointer);
    }

    [CallerCount(15)]
    [CachedScanResults(RefRangeStart = 1111468, RefRangeEnd = 1111483, XrefRangeStart = 1111401, XrefRangeEnd = 1111468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CompatibilityIssue(PersistenceIssueType persistenceIssueType, string issue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &persistenceIssueType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(issue);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityChecker.NativeMethodInfoPtr_CompatibilityIssue_Public_Void_PersistenceIssueType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111483, XrefRangeEnd = 1111520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckCanLoadFromSave<T>(T loaderVersion, T saveVersion)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) loaderVersion;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref loaderVersion;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local3;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local4 = (object) saveVersion;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local3 = local4 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local4 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local4 as Il2CppObjectBase);
      }
      else
        local3 = ref saveVersion;
      *(System.IntPtr*) num = (System.IntPtr) ref local3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityChecker.MethodInfoStoreGeneric_CheckCanLoadFromSave_Public_Void_T_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111520, XrefRangeEnd = 1111559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckChildArrayCompatibility<TEntry>(
      string arrayName,
      Il2CppArrayBase<TEntry> children,
      Il2CppArrayBase<TEntry> otherChildren)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(arrayName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) children);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) otherChildren);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityChecker.MethodInfoStoreGeneric_CheckChildArrayCompatibility_Public_Void_String_Il2CppArrayBase_1_TEntry_Il2CppArrayBase_1_TEntry_0<TEntry>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111559, XrefRangeEnd = 1111679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckChildDictionaryCompatibility<TKey, TEntry>(
      string collectionName,
      Dictionary<TKey, TEntry> thisCollection,
      Dictionary<TKey, TEntry> previousCollection,
      PersistenceIssueType removedEntriesIssueType,
      PersistenceIssueType addedEntriesIssueType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(collectionName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) thisCollection);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) previousCollection);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &removedEntriesIssueType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &addedEntriesIssueType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityChecker.MethodInfoStoreGeneric_CheckChildDictionaryCompatibility_Public_Void_String_Dictionary_2_TKey_TEntry_Dictionary_2_TKey_TEntry_PersistenceIssueType_PersistenceIssueType_0<TKey, TEntry>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1111745, RefRangeEnd = 1111746, XrefRangeStart = 1111679, XrefRangeEnd = 1111745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckHashSetCompatibility<TValue>(
      string collectionName,
      HashSet<TValue> thisCollection,
      HashSet<TValue> previousCollection,
      PersistenceIssueType removedEntriesIssueType,
      PersistenceIssueType addedEntriesIssueType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(collectionName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) thisCollection);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) previousCollection);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &removedEntriesIssueType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &addedEntriesIssueType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityChecker.MethodInfoStoreGeneric_CheckHashSetCompatibility_Public_Void_String_HashSet_1_TValue_HashSet_1_TValue_PersistenceIssueType_PersistenceIssueType_0<TValue>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1111766, RefRangeEnd = 1111767, XrefRangeStart = 1111746, XrefRangeEnd = 1111766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PersistenceCompatibilityChecker()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistenceCompatibilityChecker>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityChecker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PersistenceCompatibilityChecker()
    {
      Il2CppClassPointerStore<PersistenceCompatibilityChecker>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Compatibility", nameof (PersistenceCompatibilityChecker));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistenceCompatibilityChecker>.NativeClassPtr);
      PersistenceCompatibilityChecker.NativeFieldInfoPtr__ActiveObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityChecker>.NativeClassPtr, nameof (_ActiveObjects));
      PersistenceCompatibilityChecker.NativeFieldInfoPtr__Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityChecker>.NativeClassPtr, nameof (_Result));
      PersistenceCompatibilityChecker.NativeMethodInfoPtr_GetResult_Public_PersistenceCompatibilityResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityChecker>.NativeClassPtr, 100687973);
      PersistenceCompatibilityChecker.NativeMethodInfoPtr_CompatibilityIssue_Public_Void_PersistenceIssueType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityChecker>.NativeClassPtr, 100687974);
      PersistenceCompatibilityChecker.NativeMethodInfoPtr_CheckCanLoadFromSave_Public_Void_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityChecker>.NativeClassPtr, 100687975);
      PersistenceCompatibilityChecker.NativeMethodInfoPtr_CheckChildArrayCompatibility_Public_Void_String_Il2CppArrayBase_1_TEntry_Il2CppArrayBase_1_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityChecker>.NativeClassPtr, 100687976);
      PersistenceCompatibilityChecker.NativeMethodInfoPtr_CheckChildDictionaryCompatibility_Public_Void_String_Dictionary_2_TKey_TEntry_Dictionary_2_TKey_TEntry_PersistenceIssueType_PersistenceIssueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityChecker>.NativeClassPtr, 100687977);
      PersistenceCompatibilityChecker.NativeMethodInfoPtr_CheckHashSetCompatibility_Public_Void_String_HashSet_1_TValue_HashSet_1_TValue_PersistenceIssueType_PersistenceIssueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityChecker>.NativeClassPtr, 100687978);
      PersistenceCompatibilityChecker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityChecker>.NativeClassPtr, 100687979);
    }

    public PersistenceCompatibilityChecker(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Stack<Il2CppSystem.Func<string>> _ActiveObjects
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityChecker.NativeFieldInfoPtr__ActiveObjects));
        return pointer == System.IntPtr.Zero ? (Stack<Il2CppSystem.Func<string>>) null : new Stack<Il2CppSystem.Func<string>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityChecker.NativeFieldInfoPtr__ActiveObjects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PersistenceCompatibilityResult _Result
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityChecker.NativeFieldInfoPtr__Result));
        return pointer == System.IntPtr.Zero ? (PersistenceCompatibilityResult) null : new PersistenceCompatibilityResult(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityChecker.NativeFieldInfoPtr__Result), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.Compatibility.PersistenceCompatibilityChecker/<>c__DisplayClass5_0`1")]
    public sealed class __c__DisplayClass5_0<TEntry> : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_arrayName;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__CheckChildArrayCompatibility_b__0_Internal_String_0;

      [CallerCount(653)]
      [CachedScanResults(RefRangeStart = 134013, RefRangeEnd = 134666, XrefRangeStart = 134013, XrefRangeEnd = 134666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass5_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistenceCompatibilityChecker.__c__DisplayClass5_0<TEntry>>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityChecker.__c__DisplayClass5_0<TEntry>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(8)]
      [CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _CheckChildArrayCompatibility_b__0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityChecker.__c__DisplayClass5_0<TEntry>.NativeMethodInfoPtr__CheckChildArrayCompatibility_b__0_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static __c__DisplayClass5_0()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<PersistenceCompatibilityChecker.__c__DisplayClass5_0<TEntry>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PersistenceCompatibilityChecker>.NativeClassPtr, "<>c__DisplayClass5_0`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEntry>.NativeClassPtr))
        }))).TypeHandle).value);
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistenceCompatibilityChecker.__c__DisplayClass5_0<TEntry>>.NativeClassPtr);
        PersistenceCompatibilityChecker.__c__DisplayClass5_0<TEntry>.NativeFieldInfoPtr_arrayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityChecker.__c__DisplayClass5_0<TEntry>>.NativeClassPtr, nameof (arrayName));
        PersistenceCompatibilityChecker.__c__DisplayClass5_0<TEntry>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityChecker.__c__DisplayClass5_0<TEntry>>.NativeClassPtr, 100687980);
        PersistenceCompatibilityChecker.__c__DisplayClass5_0<TEntry>.NativeMethodInfoPtr__CheckChildArrayCompatibility_b__0_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityChecker.__c__DisplayClass5_0<TEntry>>.NativeClassPtr, 100687981);
      }

      public __c__DisplayClass5_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe string arrayName
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityChecker.__c__DisplayClass5_0<TEntry>.NativeFieldInfoPtr_arrayName)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityChecker.__c__DisplayClass5_0<TEntry>.NativeFieldInfoPtr_arrayName), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }
    }

    [ObfuscatedName("ProjectM.Compatibility.PersistenceCompatibilityChecker/<>c__DisplayClass6_0`2")]
    public sealed class __c__DisplayClass6_0<TKey, TEntry> : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_collectionName;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__CheckChildDictionaryCompatibility_b__0_Internal_String_0;

      [CallerCount(653)]
      [CachedScanResults(RefRangeStart = 134013, RefRangeEnd = 134666, XrefRangeStart = 134013, XrefRangeEnd = 134666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass6_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistenceCompatibilityChecker.__c__DisplayClass6_0<TKey, TEntry>>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityChecker.__c__DisplayClass6_0<TKey, TEntry>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(8)]
      [CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _CheckChildDictionaryCompatibility_b__0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityChecker.__c__DisplayClass6_0<TKey, TEntry>.NativeMethodInfoPtr__CheckChildDictionaryCompatibility_b__0_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static __c__DisplayClass6_0()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<PersistenceCompatibilityChecker.__c__DisplayClass6_0<TKey, TEntry>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PersistenceCompatibilityChecker>.NativeClassPtr, "<>c__DisplayClass6_0`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEntry>.NativeClassPtr))
        }))).TypeHandle).value);
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistenceCompatibilityChecker.__c__DisplayClass6_0<TKey, TEntry>>.NativeClassPtr);
        PersistenceCompatibilityChecker.__c__DisplayClass6_0<TKey, TEntry>.NativeFieldInfoPtr_collectionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityChecker.__c__DisplayClass6_0<TKey, TEntry>>.NativeClassPtr, nameof (collectionName));
        PersistenceCompatibilityChecker.__c__DisplayClass6_0<TKey, TEntry>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityChecker.__c__DisplayClass6_0<TKey, TEntry>>.NativeClassPtr, 100687982);
        PersistenceCompatibilityChecker.__c__DisplayClass6_0<TKey, TEntry>.NativeMethodInfoPtr__CheckChildDictionaryCompatibility_b__0_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityChecker.__c__DisplayClass6_0<TKey, TEntry>>.NativeClassPtr, 100687983);
      }

      public __c__DisplayClass6_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe string collectionName
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityChecker.__c__DisplayClass6_0<TKey, TEntry>.NativeFieldInfoPtr_collectionName)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityChecker.__c__DisplayClass6_0<TKey, TEntry>.NativeFieldInfoPtr_collectionName), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }
    }

    [ObfuscatedName("ProjectM.Compatibility.PersistenceCompatibilityChecker/<>c__DisplayClass7_0`1")]
    public sealed class __c__DisplayClass7_0<TValue> : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_collectionName;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__CheckHashSetCompatibility_b__0_Internal_String_0;

      [CallerCount(653)]
      [CachedScanResults(RefRangeStart = 134013, RefRangeEnd = 134666, XrefRangeStart = 134013, XrefRangeEnd = 134666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass7_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistenceCompatibilityChecker.__c__DisplayClass7_0<TValue>>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityChecker.__c__DisplayClass7_0<TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(8)]
      [CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _CheckHashSetCompatibility_b__0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityChecker.__c__DisplayClass7_0<TValue>.NativeMethodInfoPtr__CheckHashSetCompatibility_b__0_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static __c__DisplayClass7_0()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<PersistenceCompatibilityChecker.__c__DisplayClass7_0<TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PersistenceCompatibilityChecker>.NativeClassPtr, "<>c__DisplayClass7_0`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
        }))).TypeHandle).value);
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistenceCompatibilityChecker.__c__DisplayClass7_0<TValue>>.NativeClassPtr);
        PersistenceCompatibilityChecker.__c__DisplayClass7_0<TValue>.NativeFieldInfoPtr_collectionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityChecker.__c__DisplayClass7_0<TValue>>.NativeClassPtr, nameof (collectionName));
        PersistenceCompatibilityChecker.__c__DisplayClass7_0<TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityChecker.__c__DisplayClass7_0<TValue>>.NativeClassPtr, 100687984);
        PersistenceCompatibilityChecker.__c__DisplayClass7_0<TValue>.NativeMethodInfoPtr__CheckHashSetCompatibility_b__0_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityChecker.__c__DisplayClass7_0<TValue>>.NativeClassPtr, 100687985);
      }

      public __c__DisplayClass7_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe string collectionName
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityChecker.__c__DisplayClass7_0<TValue>.NativeFieldInfoPtr_collectionName)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityChecker.__c__DisplayClass7_0<TValue>.NativeFieldInfoPtr_collectionName), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }
    }

    private sealed class MethodInfoStoreGeneric_CheckCanLoadFromSave_Public_Void_T_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PersistenceCompatibilityChecker.NativeMethodInfoPtr_CheckCanLoadFromSave_Public_Void_T_T_0, Il2CppClassPointerStore<PersistenceCompatibilityChecker>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_CheckChildArrayCompatibility_Public_Void_String_Il2CppArrayBase_1_TEntry_Il2CppArrayBase_1_TEntry_0<TEntry>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PersistenceCompatibilityChecker.NativeMethodInfoPtr_CheckChildArrayCompatibility_Public_Void_String_Il2CppArrayBase_1_TEntry_Il2CppArrayBase_1_TEntry_0, Il2CppClassPointerStore<PersistenceCompatibilityChecker>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEntry>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_CheckChildDictionaryCompatibility_Public_Void_String_Dictionary_2_TKey_TEntry_Dictionary_2_TKey_TEntry_PersistenceIssueType_PersistenceIssueType_0<TKey, TEntry>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PersistenceCompatibilityChecker.NativeMethodInfoPtr_CheckChildDictionaryCompatibility_Public_Void_String_Dictionary_2_TKey_TEntry_Dictionary_2_TKey_TEntry_PersistenceIssueType_PersistenceIssueType_0, Il2CppClassPointerStore<PersistenceCompatibilityChecker>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEntry>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_CheckHashSetCompatibility_Public_Void_String_HashSet_1_TValue_HashSet_1_TValue_PersistenceIssueType_PersistenceIssueType_0<TValue>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PersistenceCompatibilityChecker.NativeMethodInfoPtr_CheckHashSetCompatibility_Public_Void_String_HashSet_1_TValue_HashSet_1_TValue_PersistenceIssueType_PersistenceIssueType_0, Il2CppClassPointerStore<PersistenceCompatibilityChecker>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
      }))));
    }
  }
}
