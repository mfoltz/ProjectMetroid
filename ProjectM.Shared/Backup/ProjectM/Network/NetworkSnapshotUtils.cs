// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.NetworkSnapshotUtils
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Network
{
  public static class NetworkSnapshotUtils : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetType_NetworkSnapshotTypes_Private_Static_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetType_NetworkedComponentConversion_Private_Static_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetDelegateField_Private_Static_Boolean_Type_String_byref_TDelegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetNameFromType_Public_Static_Boolean_NetworkSnapshotType_byref_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetNameFromType_Public_Static_Boolean_String_byref_NetworkSnapshotType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindMatchingSnapshot_Public_Static_Boolean_NetworkSnapshotIdentifier_byref_NetworkSnapshotData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryAttachSnapshot_Public_Static_Boolean_Entity_NetworkSnapshotType_EntityManager_EntityCommandBuffer_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ValidateComponentSizes_Public_Static_Void_0;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 789759, RefRangeEnd = 789763, XrefRangeStart = 789749, XrefRangeEnd = 789759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppSystem.Type GetType_NetworkSnapshotTypes()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotUtils.NativeMethodInfoPtr_GetType_NetworkSnapshotTypes_Private_Static_Type_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Type) null : new Il2CppSystem.Type(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 789763, XrefRangeEnd = 789773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppSystem.Type GetType_NetworkedComponentConversion()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotUtils.NativeMethodInfoPtr_GetType_NetworkedComponentConversion_Private_Static_Type_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Type) null : new Il2CppSystem.Type(pointer);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 789785, RefRangeEnd = 789790, XrefRangeStart = 789773, XrefRangeEnd = 789785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetDelegateField<TDelegate>(
      Il2CppSystem.Type type,
      string delegateFieldName,
      out TDelegate function)
      where TDelegate : Il2CppSystem.Delegate
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(delegateFieldName);
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      TDelegate& local1;
      if (!typeof (TDelegate).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(TDelegate*) &zero);
      }
      else
        local1 = ref function;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotUtils.MethodInfoStoreGeneric_TryGetDelegateField_Private_Static_Boolean_Type_String_byref_TDelegate_0<TDelegate>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (TDelegate).IsValueType)
      {
        ref TDelegate local2 = ref function;
        System.IntPtr objectPointer = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TDelegate>(objectPointer, false, false);
        local2 = (TDelegate) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 789790, XrefRangeEnd = 789799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetNameFromType(NetworkSnapshotType type, out string name)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) &type;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotUtils.NativeMethodInfoPtr_TryGetNameFromType_Public_Static_Boolean_NetworkSnapshotType_byref_String_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      name = IL2CPP.Il2CppStringToManaged(zero);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 789799, XrefRangeEnd = 789808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetNameFromType(string name, out NetworkSnapshotType type)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref type;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotUtils.NativeMethodInfoPtr_TryGetNameFromType_Public_Static_Boolean_String_byref_NetworkSnapshotType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 789817, RefRangeEnd = 789818, XrefRangeStart = 789808, XrefRangeEnd = 789817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryFindMatchingSnapshot(
      NetworkSnapshotIdentifier snapshotIdentifier,
      out NetworkSnapshotData snapshotData)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) snapshotIdentifier);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotUtils.NativeMethodInfoPtr_TryFindMatchingSnapshot_Public_Static_Boolean_NetworkSnapshotIdentifier_byref_NetworkSnapshotData_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref NetworkSnapshotData local = ref snapshotData;
      System.IntPtr pointer = zero;
      NetworkSnapshotData networkSnapshotData = pointer == System.IntPtr.Zero ? (NetworkSnapshotData) null : new NetworkSnapshotData(pointer);
      local = networkSnapshotData;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 789818, XrefRangeEnd = 789841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryAttachSnapshot(
      Entity entity,
      NetworkSnapshotType snapshotType,
      EntityManager entityManager,
      EntityCommandBuffer entityCommandBuffer,
      bool isServerWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &entityCommandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &isServerWorld;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotUtils.NativeMethodInfoPtr_TryAttachSnapshot_Public_Static_Boolean_Entity_NetworkSnapshotType_EntityManager_EntityCommandBuffer_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ValidateComponentSizes()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotUtils.NativeMethodInfoPtr_ValidateComponentSizes_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static NetworkSnapshotUtils()
    {
      Il2CppClassPointerStore<NetworkSnapshotUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (NetworkSnapshotUtils));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkSnapshotUtils>.NativeClassPtr);
      NetworkSnapshotUtils.NativeMethodInfoPtr_GetType_NetworkSnapshotTypes_Private_Static_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotUtils>.NativeClassPtr, 100669470);
      NetworkSnapshotUtils.NativeMethodInfoPtr_GetType_NetworkedComponentConversion_Private_Static_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotUtils>.NativeClassPtr, 100669471);
      NetworkSnapshotUtils.NativeMethodInfoPtr_TryGetDelegateField_Private_Static_Boolean_Type_String_byref_TDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotUtils>.NativeClassPtr, 100669472);
      NetworkSnapshotUtils.NativeMethodInfoPtr_TryGetNameFromType_Public_Static_Boolean_NetworkSnapshotType_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotUtils>.NativeClassPtr, 100669473);
      NetworkSnapshotUtils.NativeMethodInfoPtr_TryGetNameFromType_Public_Static_Boolean_String_byref_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotUtils>.NativeClassPtr, 100669474);
      NetworkSnapshotUtils.NativeMethodInfoPtr_TryFindMatchingSnapshot_Public_Static_Boolean_NetworkSnapshotIdentifier_byref_NetworkSnapshotData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotUtils>.NativeClassPtr, 100669475);
      NetworkSnapshotUtils.NativeMethodInfoPtr_TryAttachSnapshot_Public_Static_Boolean_Entity_NetworkSnapshotType_EntityManager_EntityCommandBuffer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotUtils>.NativeClassPtr, 100669476);
      NetworkSnapshotUtils.NativeMethodInfoPtr_ValidateComponentSizes_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotUtils>.NativeClassPtr, 100669477);
    }

    public NetworkSnapshotUtils(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public sealed class TryGetNameFromTypeDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_NetworkSnapshotType_byref_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_NetworkSnapshotType_byref_String_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TryGetNameFromTypeDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkSnapshotUtils.TryGetNameFromTypeDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotUtils.TryGetNameFromTypeDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 789722, RefRangeEnd = 789724, XrefRangeStart = 789722, XrefRangeEnd = 789722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Invoke(NetworkSnapshotType type, out string name)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
        numPtr1[0] = (System.IntPtr) &type;
        System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
        System.IntPtr zero = System.IntPtr.Zero;
        System.IntPtr* numPtr2 = &zero;
        *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
        System.IntPtr exc;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotUtils.TryGetNameFromTypeDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_NetworkSnapshotType_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        name = IL2CPP.Il2CppStringToManaged(zero);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 789724, XrefRangeEnd = 789728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        NetworkSnapshotType type,
        out string name,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
        numPtr1[0] = (System.IntPtr) &type;
        System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
        System.IntPtr zero = System.IntPtr.Zero;
        System.IntPtr* numPtr2 = &zero;
        *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
        *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotUtils.TryGetNameFromTypeDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_NetworkSnapshotType_byref_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        name = IL2CPP.Il2CppStringToManaged(zero);
        System.IntPtr pointer = num2;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool EndInvoke(out string name, Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
        System.IntPtr* numPtr2 = numPtr1;
        System.IntPtr zero = System.IntPtr.Zero;
        System.IntPtr* numPtr3 = &zero;
        *numPtr2 = (System.IntPtr) numPtr3;
        *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotUtils.TryGetNameFromTypeDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        name = IL2CPP.Il2CppStringToManaged(zero);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static TryGetNameFromTypeDelegate()
      {
        Il2CppClassPointerStore<NetworkSnapshotUtils.TryGetNameFromTypeDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetworkSnapshotUtils>.NativeClassPtr, nameof (TryGetNameFromTypeDelegate));
        NetworkSnapshotUtils.TryGetNameFromTypeDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotUtils.TryGetNameFromTypeDelegate>.NativeClassPtr, 100669478);
        NetworkSnapshotUtils.TryGetNameFromTypeDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_NetworkSnapshotType_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotUtils.TryGetNameFromTypeDelegate>.NativeClassPtr, 100669479);
        NetworkSnapshotUtils.TryGetNameFromTypeDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_NetworkSnapshotType_byref_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotUtils.TryGetNameFromTypeDelegate>.NativeClassPtr, 100669480);
        NetworkSnapshotUtils.TryGetNameFromTypeDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotUtils.TryGetNameFromTypeDelegate>.NativeClassPtr, 100669481);
      }

      public TryGetNameFromTypeDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public sealed class TryFindMatchingSnapshotDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_NetworkSnapshotIdentifier_byref_NetworkSnapshotData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_NetworkSnapshotIdentifier_byref_NetworkSnapshotData_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_NetworkSnapshotData_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TryFindMatchingSnapshotDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkSnapshotUtils.TryFindMatchingSnapshotDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotUtils.TryFindMatchingSnapshotDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 412811, RefRangeEnd = 412815, XrefRangeStart = 412811, XrefRangeEnd = 412815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Invoke(
        NetworkSnapshotIdentifier snapshotIdentifier,
        out NetworkSnapshotData snapshotData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
        numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) snapshotIdentifier);
        System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
        System.IntPtr zero = System.IntPtr.Zero;
        System.IntPtr* numPtr2 = &zero;
        *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
        System.IntPtr exc;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotUtils.TryFindMatchingSnapshotDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_NetworkSnapshotIdentifier_byref_NetworkSnapshotData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref NetworkSnapshotData local = ref snapshotData;
        System.IntPtr pointer = zero;
        NetworkSnapshotData networkSnapshotData = pointer == System.IntPtr.Zero ? (NetworkSnapshotData) null : new NetworkSnapshotData(pointer);
        local = networkSnapshotData;
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        NetworkSnapshotIdentifier snapshotIdentifier,
        out NetworkSnapshotData snapshotData,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
        numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) snapshotIdentifier);
        System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
        System.IntPtr zero = System.IntPtr.Zero;
        System.IntPtr* numPtr2 = &zero;
        *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
        *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotUtils.TryFindMatchingSnapshotDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_NetworkSnapshotIdentifier_byref_NetworkSnapshotData_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref NetworkSnapshotData local = ref snapshotData;
        System.IntPtr pointer1 = zero;
        NetworkSnapshotData networkSnapshotData = pointer1 == System.IntPtr.Zero ? (NetworkSnapshotData) null : new NetworkSnapshotData(pointer1);
        local = networkSnapshotData;
        System.IntPtr pointer2 = num2;
        return pointer2 == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool EndInvoke(
        out NetworkSnapshotData snapshotData,
        Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
        System.IntPtr* numPtr2 = numPtr1;
        System.IntPtr zero = System.IntPtr.Zero;
        System.IntPtr* numPtr3 = &zero;
        *numPtr2 = (System.IntPtr) numPtr3;
        *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotUtils.TryFindMatchingSnapshotDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_NetworkSnapshotData_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref NetworkSnapshotData local = ref snapshotData;
        System.IntPtr pointer = zero;
        NetworkSnapshotData networkSnapshotData = pointer == System.IntPtr.Zero ? (NetworkSnapshotData) null : new NetworkSnapshotData(pointer);
        local = networkSnapshotData;
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static TryFindMatchingSnapshotDelegate()
      {
        Il2CppClassPointerStore<NetworkSnapshotUtils.TryFindMatchingSnapshotDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetworkSnapshotUtils>.NativeClassPtr, nameof (TryFindMatchingSnapshotDelegate));
        NetworkSnapshotUtils.TryFindMatchingSnapshotDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotUtils.TryFindMatchingSnapshotDelegate>.NativeClassPtr, 100669482);
        NetworkSnapshotUtils.TryFindMatchingSnapshotDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_NetworkSnapshotIdentifier_byref_NetworkSnapshotData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotUtils.TryFindMatchingSnapshotDelegate>.NativeClassPtr, 100669483);
        NetworkSnapshotUtils.TryFindMatchingSnapshotDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_NetworkSnapshotIdentifier_byref_NetworkSnapshotData_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotUtils.TryFindMatchingSnapshotDelegate>.NativeClassPtr, 100669484);
        NetworkSnapshotUtils.TryFindMatchingSnapshotDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_NetworkSnapshotData_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotUtils.TryFindMatchingSnapshotDelegate>.NativeClassPtr, 100669485);
      }

      public TryFindMatchingSnapshotDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public sealed class TryGetTypeFromNameDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_String_byref_NetworkSnapshotType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_byref_NetworkSnapshotType_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_NetworkSnapshotType_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TryGetTypeFromNameDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkSnapshotUtils.TryGetTypeFromNameDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotUtils.TryGetTypeFromNameDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 412811, RefRangeEnd = 412815, XrefRangeStart = 412811, XrefRangeEnd = 412815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Invoke(string name, out NetworkSnapshotType type)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref type;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotUtils.TryGetTypeFromNameDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_String_byref_NetworkSnapshotType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 789728, XrefRangeEnd = 789732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        string name,
        out NetworkSnapshotType type,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref type;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotUtils.TryGetTypeFromNameDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_byref_NetworkSnapshotType_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool EndInvoke(out NetworkSnapshotType type, Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref type;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotUtils.TryGetTypeFromNameDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_NetworkSnapshotType_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static TryGetTypeFromNameDelegate()
      {
        Il2CppClassPointerStore<NetworkSnapshotUtils.TryGetTypeFromNameDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetworkSnapshotUtils>.NativeClassPtr, nameof (TryGetTypeFromNameDelegate));
        NetworkSnapshotUtils.TryGetTypeFromNameDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotUtils.TryGetTypeFromNameDelegate>.NativeClassPtr, 100669486);
        NetworkSnapshotUtils.TryGetTypeFromNameDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_String_byref_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotUtils.TryGetTypeFromNameDelegate>.NativeClassPtr, 100669487);
        NetworkSnapshotUtils.TryGetTypeFromNameDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_byref_NetworkSnapshotType_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotUtils.TryGetTypeFromNameDelegate>.NativeClassPtr, 100669488);
        NetworkSnapshotUtils.TryGetTypeFromNameDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_NetworkSnapshotType_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotUtils.TryGetTypeFromNameDelegate>.NativeClassPtr, 100669489);
      }

      public TryGetTypeFromNameDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public sealed class TryAttachSnapshotComponentsDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Entity_NetworkSnapshotType_EntityManager_EntityCommandBuffer_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Entity_NetworkSnapshotType_EntityManager_EntityCommandBuffer_Boolean_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TryAttachSnapshotComponentsDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkSnapshotUtils.TryAttachSnapshotComponentsDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotUtils.TryAttachSnapshotComponentsDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 789732, RefRangeEnd = 789733, XrefRangeStart = 789732, XrefRangeEnd = 789732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Invoke(
        Entity entity,
        NetworkSnapshotType snapshotType,
        EntityManager entityManager,
        EntityCommandBuffer entityCommandBuffer,
        bool isServerWorld)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &entityCommandBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &isServerWorld;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotUtils.TryAttachSnapshotComponentsDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Entity_NetworkSnapshotType_EntityManager_EntityCommandBuffer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 789733, XrefRangeEnd = 789749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        Entity entity,
        NetworkSnapshotType snapshotType,
        EntityManager entityManager,
        EntityCommandBuffer entityCommandBuffer,
        bool isServerWorld,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[7];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &entityCommandBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &isServerWorld;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotUtils.TryAttachSnapshotComponentsDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Entity_NetworkSnapshotType_EntityManager_EntityCommandBuffer_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool EndInvoke(Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotUtils.TryAttachSnapshotComponentsDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static TryAttachSnapshotComponentsDelegate()
      {
        Il2CppClassPointerStore<NetworkSnapshotUtils.TryAttachSnapshotComponentsDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetworkSnapshotUtils>.NativeClassPtr, nameof (TryAttachSnapshotComponentsDelegate));
        NetworkSnapshotUtils.TryAttachSnapshotComponentsDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotUtils.TryAttachSnapshotComponentsDelegate>.NativeClassPtr, 100669490);
        NetworkSnapshotUtils.TryAttachSnapshotComponentsDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Entity_NetworkSnapshotType_EntityManager_EntityCommandBuffer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotUtils.TryAttachSnapshotComponentsDelegate>.NativeClassPtr, 100669491);
        NetworkSnapshotUtils.TryAttachSnapshotComponentsDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Entity_NetworkSnapshotType_EntityManager_EntityCommandBuffer_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotUtils.TryAttachSnapshotComponentsDelegate>.NativeClassPtr, 100669492);
        NetworkSnapshotUtils.TryAttachSnapshotComponentsDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotUtils.TryAttachSnapshotComponentsDelegate>.NativeClassPtr, 100669493);
      }

      public TryAttachSnapshotComponentsDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static implicit operator NetworkSnapshotUtils.TryAttachSnapshotComponentsDelegate(
        [In] System.Func<Entity, NetworkSnapshotType, EntityManager, EntityCommandBuffer, bool> obj0)
      {
        return DelegateSupport.ConvertDelegate<NetworkSnapshotUtils.TryAttachSnapshotComponentsDelegate>((System.Delegate) obj0);
      }

      public static NetworkSnapshotUtils.TryAttachSnapshotComponentsDelegate operator +(
        [In] NetworkSnapshotUtils.TryAttachSnapshotComponentsDelegate obj0,
        [In] NetworkSnapshotUtils.TryAttachSnapshotComponentsDelegate obj1)
      {
        return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<NetworkSnapshotUtils.TryAttachSnapshotComponentsDelegate>();
      }

      public static NetworkSnapshotUtils.TryAttachSnapshotComponentsDelegate operator -(
        [In] NetworkSnapshotUtils.TryAttachSnapshotComponentsDelegate obj0,
        [In] NetworkSnapshotUtils.TryAttachSnapshotComponentsDelegate obj1)
      {
        Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
        return (object) @delegate == null ? (NetworkSnapshotUtils.TryAttachSnapshotComponentsDelegate) @delegate : @delegate.Cast<NetworkSnapshotUtils.TryAttachSnapshotComponentsDelegate>();
      }
    }

    public sealed class ValidateComponentSizesDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ValidateComponentSizesDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkSnapshotUtils.ValidateComponentSizesDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotUtils.ValidateComponentSizesDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 298957, RefRangeEnd = 298968, XrefRangeStart = 298957, XrefRangeEnd = 298968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotUtils.ValidateComponentSizesDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotUtils.ValidateComponentSizesDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotUtils.ValidateComponentSizesDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ValidateComponentSizesDelegate()
      {
        Il2CppClassPointerStore<NetworkSnapshotUtils.ValidateComponentSizesDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetworkSnapshotUtils>.NativeClassPtr, nameof (ValidateComponentSizesDelegate));
        NetworkSnapshotUtils.ValidateComponentSizesDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotUtils.ValidateComponentSizesDelegate>.NativeClassPtr, 100669494);
        NetworkSnapshotUtils.ValidateComponentSizesDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotUtils.ValidateComponentSizesDelegate>.NativeClassPtr, 100669495);
        NetworkSnapshotUtils.ValidateComponentSizesDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotUtils.ValidateComponentSizesDelegate>.NativeClassPtr, 100669496);
        NetworkSnapshotUtils.ValidateComponentSizesDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotUtils.ValidateComponentSizesDelegate>.NativeClassPtr, 100669497);
      }

      public ValidateComponentSizesDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static implicit operator NetworkSnapshotUtils.ValidateComponentSizesDelegate(
        [In] System.Action obj0)
      {
        return DelegateSupport.ConvertDelegate<NetworkSnapshotUtils.ValidateComponentSizesDelegate>((System.Delegate) obj0);
      }

      public static NetworkSnapshotUtils.ValidateComponentSizesDelegate operator +(
        [In] NetworkSnapshotUtils.ValidateComponentSizesDelegate obj0,
        [In] NetworkSnapshotUtils.ValidateComponentSizesDelegate obj1)
      {
        return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<NetworkSnapshotUtils.ValidateComponentSizesDelegate>();
      }

      public static NetworkSnapshotUtils.ValidateComponentSizesDelegate operator -(
        [In] NetworkSnapshotUtils.ValidateComponentSizesDelegate obj0,
        [In] NetworkSnapshotUtils.ValidateComponentSizesDelegate obj1)
      {
        Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
        return (object) @delegate == null ? (NetworkSnapshotUtils.ValidateComponentSizesDelegate) @delegate : @delegate.Cast<NetworkSnapshotUtils.ValidateComponentSizesDelegate>();
      }
    }

    private sealed class MethodInfoStoreGeneric_TryGetDelegateField_Private_Static_Boolean_Type_String_byref_TDelegate_0<TDelegate>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NetworkSnapshotUtils.NativeMethodInfoPtr_TryGetDelegateField_Private_Static_Boolean_Type_String_byref_TDelegate_0, Il2CppClassPointerStore<NetworkSnapshotUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDelegate>.NativeClassPtr))
      }))));
    }
  }
}
