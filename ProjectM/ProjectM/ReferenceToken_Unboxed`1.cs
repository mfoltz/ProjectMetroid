﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.ReferenceToken_Unboxed`1
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

#nullable disable
namespace ProjectM
{
  public struct ReferenceToken_Unboxed<TKey> where TKey : unmanaged
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Reference;
    private static readonly System.IntPtr NativeFieldInfoPtr_UniqueToken;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_InvalidToken_Public_Static_get_ReferenceToken_Unboxed_1_TKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ReferenceToken_Unboxed_1_TKey_ReferenceToken_Unboxed_1_TKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ReferenceToken_Unboxed_1_TKey_ReferenceToken_Unboxed_1_TKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ReferenceToken_Unboxed_1_TKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    public TKey Reference;
    public int UniqueToken;

    public static unsafe ReferenceToken_Unboxed<TKey> InvalidToken
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReferenceToken_Unboxed<TKey>.NativeMethodInfoPtr_get_InvalidToken_Public_Static_get_ReferenceToken_Unboxed_1_TKey_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ReferenceToken_Unboxed<TKey>*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073817, XrefRangeEnd = 1073822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator !=(
      ReferenceToken_Unboxed<TKey> token1,
      ReferenceToken_Unboxed<TKey> token2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &token1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &token2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReferenceToken_Unboxed<TKey>.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ReferenceToken_Unboxed_1_TKey_ReferenceToken_Unboxed_1_TKey_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1073827, RefRangeEnd = 1073828, XrefRangeStart = 1073822, XrefRangeEnd = 1073827, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator ==(
      ReferenceToken_Unboxed<TKey> token1,
      ReferenceToken_Unboxed<TKey> token2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &token1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &token2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReferenceToken_Unboxed<TKey>.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ReferenceToken_Unboxed_1_TKey_ReferenceToken_Unboxed_1_TKey_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073828, XrefRangeEnd = 1073832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(ReferenceToken_Unboxed<TKey> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReferenceToken_Unboxed<TKey>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ReferenceToken_Unboxed_1_TKey_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073832, XrefRangeEnd = 1073835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReferenceToken_Unboxed<TKey>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1073836, RefRangeEnd = 1073837, XrefRangeStart = 1073835, XrefRangeEnd = 1073836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReferenceToken_Unboxed<TKey>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ReferenceToken_Unboxed()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<ReferenceToken_Unboxed<TKey>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", "ReferenceToken`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReferenceToken_Unboxed<TKey>>.NativeClassPtr);
      ReferenceToken_Unboxed<TKey>.NativeFieldInfoPtr_Reference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceToken_Unboxed<TKey>>.NativeClassPtr, nameof (Reference));
      ReferenceToken_Unboxed<TKey>.NativeFieldInfoPtr_UniqueToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceToken_Unboxed<TKey>>.NativeClassPtr, nameof (UniqueToken));
      ReferenceToken_Unboxed<TKey>.NativeMethodInfoPtr_get_InvalidToken_Public_Static_get_ReferenceToken_Unboxed_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceToken_Unboxed<TKey>>.NativeClassPtr, 100684603);
      ReferenceToken_Unboxed<TKey>.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ReferenceToken_Unboxed_1_TKey_ReferenceToken_Unboxed_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceToken_Unboxed<TKey>>.NativeClassPtr, 100684604);
      ReferenceToken_Unboxed<TKey>.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ReferenceToken_Unboxed_1_TKey_ReferenceToken_Unboxed_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceToken_Unboxed<TKey>>.NativeClassPtr, 100684605);
      ReferenceToken_Unboxed<TKey>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ReferenceToken_Unboxed_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceToken_Unboxed<TKey>>.NativeClassPtr, 100684606);
      ReferenceToken_Unboxed<TKey>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceToken_Unboxed<TKey>>.NativeClassPtr, 100684607);
      ReferenceToken_Unboxed<TKey>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceToken_Unboxed<TKey>>.NativeClassPtr, 100684608);
    }

    public ReferenceToken<TKey> BoxIl2CppObject()
    {
      return new ReferenceToken<TKey>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReferenceToken_Unboxed<TKey>>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
