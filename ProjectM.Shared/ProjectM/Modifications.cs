// Decompiled with JetBrains decompiler
// Type: ProjectM.Modifications
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class Modifications : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_BinarySearchModifiableIndex_Public_Static_Boolean_Int32_DynamicBuffer_1_TMod_byref_Int32_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DebugOrder_Public_Static_Void_DynamicBuffer_1_TMod_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyModification_Public_Static_Boolean_byref_TModifiable_ModificationIDs_ModificationType_TModValue_Int32_DynamicBuffer_1_TMod_Entity_byref_ModificationId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifyModification_Public_Static_Boolean_ModificationId_TModValue_DynamicBuffer_1_TMod_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveModification_Public_Static_Boolean_byref_TModifiable_ModificationId_DynamicBuffer_1_TMod_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746727, XrefRangeEnd = 746760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool BinarySearchModifiableIndex<TMod, TModValue>(
      int modifiableIdentifier,
      DynamicBuffer<TMod> modifications,
      out int index,
      bool debugMode = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &modifiableIdentifier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &modifications;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &debugMode;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Modifications.MethodInfoStoreGeneric_BinarySearchModifiableIndex_Public_Static_Boolean_Int32_DynamicBuffer_1_TMod_byref_Int32_Boolean_0<TMod, TModValue>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746760, XrefRangeEnd = 746772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DebugOrder<TMod, TModValue>(DynamicBuffer<TMod> modifications)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &modifications;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Modifications.MethodInfoStoreGeneric_DebugOrder_Public_Static_Void_DynamicBuffer_1_TMod_0<TMod, TModValue>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746772, XrefRangeEnd = 746806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ApplyModification<TModifiable, TMod, TModValue>(
      ref TModifiable modifiable,
      ModificationIDs modificationIDs,
      ModificationType modType,
      TModValue modValue,
      int priority,
      DynamicBuffer<TMod> modifications,
      Entity source,
      out ModificationId modificationId)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[8];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) modifiable);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &modificationIDs;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &modType;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TModValue& local1;
      if (!typeof (TModValue).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TModValue> local2 = (object) modValue;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TModValue&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TModValue&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref modValue;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &priority;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &modifications;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &source;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref modificationId;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Modifications.MethodInfoStoreGeneric_ApplyModification_Public_Static_Boolean_byref_TModifiable_ModificationIDs_ModificationType_TModValue_Int32_DynamicBuffer_1_TMod_Entity_byref_ModificationId_0<TModifiable, TMod, TModValue>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TModifiable local3 = ref modifiable;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TModifiable>(objectPointer, false, false);
      local3 = (TModifiable) valueGeneric;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746806, XrefRangeEnd = 746809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ModifyModification<TMod, TModValue>(
      ModificationId id,
      TModValue modValue,
      DynamicBuffer<TMod> modifications)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &id;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TModValue& local1;
      if (!typeof (TModValue).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TModValue> local2 = (object) modValue;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TModValue&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TModValue&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref modValue;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &modifications;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Modifications.MethodInfoStoreGeneric_ModifyModification_Public_Static_Boolean_ModificationId_TModValue_DynamicBuffer_1_TMod_0<TMod, TModValue>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746809, XrefRangeEnd = 746828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool RemoveModification<TModifiable, TMod, TModValue>(
      ref TModifiable modifiable,
      ModificationId id,
      DynamicBuffer<TMod> modifications)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) modifiable);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &modifications;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Modifications.MethodInfoStoreGeneric_RemoveModification_Public_Static_Boolean_byref_TModifiable_ModificationId_DynamicBuffer_1_TMod_0<TModifiable, TMod, TModValue>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TModifiable local = ref modifiable;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TModifiable>(objectPointer, false, false);
      local = (TModifiable) valueGeneric;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static Modifications()
    {
      Il2CppClassPointerStore<Modifications>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Modifications));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Modifications>.NativeClassPtr);
      Modifications.NativeMethodInfoPtr_BinarySearchModifiableIndex_Public_Static_Boolean_Int32_DynamicBuffer_1_TMod_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Modifications>.NativeClassPtr, 100665711);
      Modifications.NativeMethodInfoPtr_DebugOrder_Public_Static_Void_DynamicBuffer_1_TMod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Modifications>.NativeClassPtr, 100665712);
      Modifications.NativeMethodInfoPtr_ApplyModification_Public_Static_Boolean_byref_TModifiable_ModificationIDs_ModificationType_TModValue_Int32_DynamicBuffer_1_TMod_Entity_byref_ModificationId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Modifications>.NativeClassPtr, 100665713);
      Modifications.NativeMethodInfoPtr_ModifyModification_Public_Static_Boolean_ModificationId_TModValue_DynamicBuffer_1_TMod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Modifications>.NativeClassPtr, 100665714);
      Modifications.NativeMethodInfoPtr_RemoveModification_Public_Static_Boolean_byref_TModifiable_ModificationId_DynamicBuffer_1_TMod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Modifications>.NativeClassPtr, 100665715);
    }

    public Modifications(System.IntPtr pointer)
      : base(pointer)
    {
    }

    private sealed class MethodInfoStoreGeneric_BinarySearchModifiableIndex_Public_Static_Boolean_Int32_DynamicBuffer_1_TMod_byref_Int32_Boolean_0<TMod, TModValue>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Modifications.NativeMethodInfoPtr_BinarySearchModifiableIndex_Public_Static_Boolean_Int32_DynamicBuffer_1_TMod_byref_Int32_Boolean_0, Il2CppClassPointerStore<Modifications>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMod>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TModValue>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_DebugOrder_Public_Static_Void_DynamicBuffer_1_TMod_0<TMod, TModValue>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Modifications.NativeMethodInfoPtr_DebugOrder_Public_Static_Void_DynamicBuffer_1_TMod_0, Il2CppClassPointerStore<Modifications>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMod>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TModValue>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_ApplyModification_Public_Static_Boolean_byref_TModifiable_ModificationIDs_ModificationType_TModValue_Int32_DynamicBuffer_1_TMod_Entity_byref_ModificationId_0<TModifiable, TMod, TModValue>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Modifications.NativeMethodInfoPtr_ApplyModification_Public_Static_Boolean_byref_TModifiable_ModificationIDs_ModificationType_TModValue_Int32_DynamicBuffer_1_TMod_Entity_byref_ModificationId_0, Il2CppClassPointerStore<Modifications>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TModifiable>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMod>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TModValue>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_ModifyModification_Public_Static_Boolean_ModificationId_TModValue_DynamicBuffer_1_TMod_0<TMod, TModValue>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Modifications.NativeMethodInfoPtr_ModifyModification_Public_Static_Boolean_ModificationId_TModValue_DynamicBuffer_1_TMod_0, Il2CppClassPointerStore<Modifications>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMod>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TModValue>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_RemoveModification_Public_Static_Boolean_byref_TModifiable_ModificationId_DynamicBuffer_1_TMod_0<TModifiable, TMod, TModValue>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Modifications.NativeMethodInfoPtr_RemoveModification_Public_Static_Boolean_byref_TModifiable_ModificationId_DynamicBuffer_1_TMod_0, Il2CppClassPointerStore<Modifications>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TModifiable>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMod>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TModValue>.NativeClassPtr))
      }))));
    }
  }
}
