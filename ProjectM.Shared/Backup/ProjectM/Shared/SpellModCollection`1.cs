// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.SpellModCollection`1
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Unity.Collections;

#nullable disable
namespace ProjectM.Shared
{
  public struct SpellModCollection<T>
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellModBlobs;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSpellMod_Public_Boolean_PrefabGUID_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Register_Public_Void_PrefabGUID_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAllSpellModIds_Public_NativeArray_1_PrefabGUID_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    public NativeHashMap<PrefabGUID, T> SpellModBlobs;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 798704, RefRangeEnd = 798706, XrefRangeStart = 798702, XrefRangeEnd = 798704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpellModCollection(int initialCapacity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &initialCapacity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellModCollection<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(17)]
    [CachedScanResults(RefRangeStart = 798708, RefRangeEnd = 798725, XrefRangeStart = 798706, XrefRangeEnd = 798708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetSpellMod(PrefabGUID id, out T spellMod)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &id;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(T*) &zero);
      }
      else
        local1 = ref spellMod;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpellModCollection<T>.NativeMethodInfoPtr_TryGetSpellMod_Public_Boolean_PrefabGUID_byref_T_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T).IsValueType)
      {
        ref T local2 = ref spellMod;
        System.IntPtr objectPointer = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
        local2 = (T) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 798727, RefRangeEnd = 798729, XrefRangeStart = 798725, XrefRangeEnd = 798727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Register(PrefabGUID prefabGuid, T value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &prefabGuid;
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) value;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref value;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellModCollection<T>.NativeMethodInfoPtr_Register_Public_Void_PrefabGUID_T_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 798731, RefRangeEnd = 798733, XrefRangeStart = 798729, XrefRangeEnd = 798731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeArray<PrefabGUID> GetAllSpellModIds(Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &allocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModCollection<T>.NativeMethodInfoPtr_GetAllSpellModIds_Public_NativeArray_1_PrefabGUID_Allocator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeArray<PrefabGUID>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(70)]
    [CachedScanResults(RefRangeStart = 288993, RefRangeEnd = 289063, XrefRangeStart = 288993, XrefRangeEnd = 289063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellModCollection<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpellModCollection()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<SpellModCollection<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", "SpellModCollection`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellModCollection<T>>.NativeClassPtr);
      SpellModCollection<T>.NativeFieldInfoPtr_SpellModBlobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModCollection<T>>.NativeClassPtr, nameof (SpellModBlobs));
      SpellModCollection<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModCollection<T>>.NativeClassPtr, 100670432);
      SpellModCollection<T>.NativeMethodInfoPtr_TryGetSpellMod_Public_Boolean_PrefabGUID_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModCollection<T>>.NativeClassPtr, 100670433);
      SpellModCollection<T>.NativeMethodInfoPtr_Register_Public_Void_PrefabGUID_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModCollection<T>>.NativeClassPtr, 100670434);
      SpellModCollection<T>.NativeMethodInfoPtr_GetAllSpellModIds_Public_NativeArray_1_PrefabGUID_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModCollection<T>>.NativeClassPtr, 100670435);
      SpellModCollection<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModCollection<T>>.NativeClassPtr, 100670436);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellModCollection<T>>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
