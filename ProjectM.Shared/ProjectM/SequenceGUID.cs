// Decompiled with JetBrains decompiler
// Type: ProjectM.SequenceGUID
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct SequenceGUID
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GuidHash;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsEmpty_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Empty_Public_Static_get_SequenceGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SequenceGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SequenceGUID_SequenceGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SequenceGUID_SequenceGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToPrefabGUID_Public_PrefabGUID_0;
    [FieldOffset(0)]
    public int GuidHash;

    [CallerCount(20)]
    [CachedScanResults(RefRangeStart = 45001, RefRangeEnd = 45021, XrefRangeStart = 45001, XrefRangeEnd = 45021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceGUID(int guidHash)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &guidHash;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceGUID.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(129)]
    [CachedScanResults(RefRangeStart = 298273, RefRangeEnd = 298402, XrefRangeStart = 298273, XrefRangeEnd = 298402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsEmpty()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGUID.NativeMethodInfoPtr_IsEmpty_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    public static unsafe SequenceGUID Empty
    {
      [CallerCount(1474), CachedScanResults(RefRangeStart = 31223, RefRangeEnd = 32697, XrefRangeStart = 31223, XrefRangeEnd = 32697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGUID.NativeMethodInfoPtr_get_Empty_Public_Static_get_SequenceGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(SequenceGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(14)]
    [CachedScanResults(RefRangeStart = 535674, RefRangeEnd = 535688, XrefRangeStart = 535674, XrefRangeEnd = 535688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(SequenceGUID other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGUID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SequenceGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(189)]
    [CachedScanResults(RefRangeStart = 535688, RefRangeEnd = 535877, XrefRangeStart = 535688, XrefRangeEnd = 535877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator !=(SequenceGUID guid1, SequenceGUID guid2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &guid1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &guid2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGUID.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SequenceGUID_SequenceGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(342)]
    [CachedScanResults(RefRangeStart = 535877, RefRangeEnd = 536219, XrefRangeStart = 535877, XrefRangeEnd = 536219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator ==(SequenceGUID guid1, SequenceGUID guid2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &guid1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &guid2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGUID.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SequenceGUID_SequenceGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727617, XrefRangeEnd = 727620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGUID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 727621, RefRangeEnd = 727622, XrefRangeStart = 727620, XrefRangeEnd = 727621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGUID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(409)]
    [CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrefabGUID ToPrefabGUID()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGUID.NativeMethodInfoPtr_ToPrefabGUID_Public_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SequenceGUID()
    {
      Il2CppClassPointerStore<SequenceGUID>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SequenceGUID));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceGUID>.NativeClassPtr);
      SequenceGUID.NativeFieldInfoPtr_GuidHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceGUID>.NativeClassPtr, nameof (GuidHash));
      SequenceGUID.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGUID>.NativeClassPtr, 100664416);
      SequenceGUID.NativeMethodInfoPtr_IsEmpty_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGUID>.NativeClassPtr, 100664417);
      SequenceGUID.NativeMethodInfoPtr_get_Empty_Public_Static_get_SequenceGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGUID>.NativeClassPtr, 100664418);
      SequenceGUID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SequenceGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGUID>.NativeClassPtr, 100664419);
      SequenceGUID.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SequenceGUID_SequenceGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGUID>.NativeClassPtr, 100664420);
      SequenceGUID.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SequenceGUID_SequenceGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGUID>.NativeClassPtr, 100664421);
      SequenceGUID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGUID>.NativeClassPtr, 100664422);
      SequenceGUID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGUID>.NativeClassPtr, 100664423);
      SequenceGUID.NativeMethodInfoPtr_ToPrefabGUID_Public_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGUID>.NativeClassPtr, 100664424);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SequenceGUID>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
