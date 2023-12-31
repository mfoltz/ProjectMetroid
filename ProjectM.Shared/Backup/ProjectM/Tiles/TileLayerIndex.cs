// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileLayerIndex
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TileLayerIndex
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Index;
    private static readonly System.IntPtr NativeFieldInfoPtr_Invalid;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TileLayerIndex_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_TileLayerIndex_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_TileLayerIndex_TileLayerIndex_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_TileLayerIndex_TileLayerIndex_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_TileLayerIndex_TileLayerIndex_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_TileLayerIndex_TileLayerIndex_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TileLayerIndex_TileLayerIndex_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TileLayerIndex_TileLayerIndex_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_TileLayerIndex_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_TileLayerIndex_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_TileLayerIndex_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_TileLayerIndex_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TileLayerIndex_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TileLayerIndex_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_TileLayerIndex_TileLayerIndex_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_TileLayerIndex_TileLayerIndex_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    [FieldOffset(0)]
    public byte Index;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 246533, RefRangeEnd = 246534, XrefRangeStart = 246533, XrefRangeEnd = 246534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileLayerIndex(byte tileLayerIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &tileLayerIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileLayerIndex.NativeMethodInfoPtr__ctor_Public_Void_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(15)]
    [CachedScanResults(RefRangeStart = 731961, RefRangeEnd = 731976, XrefRangeStart = 731961, XrefRangeEnd = 731976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(TileLayerIndex other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayerIndex.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TileLayerIndex_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792155, XrefRangeEnd = 792158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayerIndex.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayerIndex.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792158, XrefRangeEnd = 792159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe int CompareTo(TileLayerIndex other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayerIndex.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_TileLayerIndex_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 792159, RefRangeEnd = 792160, XrefRangeStart = 792159, XrefRangeEnd = 792159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator <(TileLayerIndex v1, TileLayerIndex v2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &v1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &v2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayerIndex.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_TileLayerIndex_TileLayerIndex_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool operator >(TileLayerIndex v1, TileLayerIndex v2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &v1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &v2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayerIndex.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_TileLayerIndex_TileLayerIndex_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool operator <=(TileLayerIndex v1, TileLayerIndex v2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &v1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &v2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayerIndex.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_TileLayerIndex_TileLayerIndex_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool operator >=(TileLayerIndex v1, TileLayerIndex v2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &v1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &v2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayerIndex.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_TileLayerIndex_TileLayerIndex_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool operator ==(TileLayerIndex v1, TileLayerIndex v2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &v1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &v2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayerIndex.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TileLayerIndex_TileLayerIndex_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool operator !=(TileLayerIndex v1, TileLayerIndex v2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &v1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &v2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayerIndex.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TileLayerIndex_TileLayerIndex_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 792160, RefRangeEnd = 792171, XrefRangeStart = 792160, XrefRangeEnd = 792160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator <(TileLayerIndex v1, int v2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &v1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &v2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayerIndex.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_TileLayerIndex_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool operator >(TileLayerIndex v1, int v2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &v1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &v2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayerIndex.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_TileLayerIndex_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool operator <=(TileLayerIndex v1, int v2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &v1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &v2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayerIndex.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_TileLayerIndex_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool operator >=(TileLayerIndex v1, int v2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &v1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &v2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayerIndex.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_TileLayerIndex_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool operator ==(TileLayerIndex v1, int v2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &v1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &v2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayerIndex.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TileLayerIndex_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool operator !=(TileLayerIndex v1, int v2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &v1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &v2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayerIndex.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TileLayerIndex_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 792171, RefRangeEnd = 792182, XrefRangeStart = 792171, XrefRangeEnd = 792171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileLayerIndex operator ++(TileLayerIndex a)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &a;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayerIndex.NativeMethodInfoPtr_op_Increment_Public_Static_TileLayerIndex_TileLayerIndex_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileLayerIndex*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe TileLayerIndex operator --(TileLayerIndex a)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &a;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayerIndex.NativeMethodInfoPtr_op_Decrement_Public_Static_TileLayerIndex_TileLayerIndex_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileLayerIndex*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 792185, RefRangeEnd = 792188, XrefRangeStart = 792182, XrefRangeEnd = 792185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TileLayerIndex.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static TileLayerIndex()
    {
      Il2CppClassPointerStore<TileLayerIndex>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (TileLayerIndex));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileLayerIndex>.NativeClassPtr);
      TileLayerIndex.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileLayerIndex>.NativeClassPtr, nameof (Index));
      TileLayerIndex.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileLayerIndex>.NativeClassPtr, nameof (Invalid));
      TileLayerIndex.NativeMethodInfoPtr__ctor_Public_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayerIndex>.NativeClassPtr, 100669715);
      TileLayerIndex.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TileLayerIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayerIndex>.NativeClassPtr, 100669716);
      TileLayerIndex.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayerIndex>.NativeClassPtr, 100669717);
      TileLayerIndex.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayerIndex>.NativeClassPtr, 100669718);
      TileLayerIndex.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_TileLayerIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayerIndex>.NativeClassPtr, 100669719);
      TileLayerIndex.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_TileLayerIndex_TileLayerIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayerIndex>.NativeClassPtr, 100669720);
      TileLayerIndex.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_TileLayerIndex_TileLayerIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayerIndex>.NativeClassPtr, 100669721);
      TileLayerIndex.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_TileLayerIndex_TileLayerIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayerIndex>.NativeClassPtr, 100669722);
      TileLayerIndex.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_TileLayerIndex_TileLayerIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayerIndex>.NativeClassPtr, 100669723);
      TileLayerIndex.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TileLayerIndex_TileLayerIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayerIndex>.NativeClassPtr, 100669724);
      TileLayerIndex.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TileLayerIndex_TileLayerIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayerIndex>.NativeClassPtr, 100669725);
      TileLayerIndex.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_TileLayerIndex_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayerIndex>.NativeClassPtr, 100669726);
      TileLayerIndex.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_TileLayerIndex_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayerIndex>.NativeClassPtr, 100669727);
      TileLayerIndex.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_TileLayerIndex_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayerIndex>.NativeClassPtr, 100669728);
      TileLayerIndex.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_TileLayerIndex_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayerIndex>.NativeClassPtr, 100669729);
      TileLayerIndex.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TileLayerIndex_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayerIndex>.NativeClassPtr, 100669730);
      TileLayerIndex.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TileLayerIndex_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayerIndex>.NativeClassPtr, 100669731);
      TileLayerIndex.NativeMethodInfoPtr_op_Increment_Public_Static_TileLayerIndex_TileLayerIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayerIndex>.NativeClassPtr, 100669732);
      TileLayerIndex.NativeMethodInfoPtr_op_Decrement_Public_Static_TileLayerIndex_TileLayerIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayerIndex>.NativeClassPtr, 100669733);
      TileLayerIndex.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayerIndex>.NativeClassPtr, 100669734);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileLayerIndex>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe TileLayerIndex Invalid
    {
      get
      {
        TileLayerIndex invalid;
        IL2CPP.il2cpp_field_static_get_value(TileLayerIndex.NativeFieldInfoPtr_Invalid, (void*) &invalid);
        return invalid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TileLayerIndex.NativeFieldInfoPtr_Invalid, (void*) &value);
      }
    }
  }
}
