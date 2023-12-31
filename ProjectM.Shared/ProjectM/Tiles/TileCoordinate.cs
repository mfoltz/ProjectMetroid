// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileCoordinate
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TileCoordinate
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_X;
    private static readonly System.IntPtr NativeFieldInfoPtr_Z;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeightLevel;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_xz_Public_get_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_int2_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_TileCoordinate_TileCoordinate_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_TileCoordinate_TileCoordinate_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromWorldPos_Public_Static_TileCoordinate_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToWorldPos_Public_Static_float3_TileCoordinate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromWorldPos_Public_Static_TileCoordinate_float2_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TileCoordinate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    [FieldOffset(0)]
    public readonly int X;
    [FieldOffset(4)]
    public readonly int Z;
    [FieldOffset(8)]
    public readonly int HeightLevel;

    public unsafe int2 xz
    {
      [CallerCount(27), CachedScanResults(RefRangeStart = 261301, RefRangeEnd = 261328, XrefRangeStart = 261301, XrefRangeEnd = 261328, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCoordinate.NativeMethodInfoPtr_get_xz_Public_get_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int2*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 792097, RefRangeEnd = 792104, XrefRangeStart = 792097, XrefRangeEnd = 792097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileCoordinate(int2 xz, int height)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &xz;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileCoordinate.NativeMethodInfoPtr__ctor_Public_Void_int2_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 220796, RefRangeEnd = 220803, XrefRangeStart = 220796, XrefRangeEnd = 220803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileCoordinate(int x, int z, int height)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &z;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileCoordinate.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(16)]
    [CachedScanResults(RefRangeStart = 792104, RefRangeEnd = 792120, XrefRangeStart = 792104, XrefRangeEnd = 792104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileCoordinate operator +(TileCoordinate a, int2 b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCoordinate.NativeMethodInfoPtr_op_Addition_Public_Static_TileCoordinate_TileCoordinate_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileCoordinate*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe TileCoordinate operator -(TileCoordinate a, int2 b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCoordinate.NativeMethodInfoPtr_op_Subtraction_Public_Static_TileCoordinate_TileCoordinate_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileCoordinate*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 792123, RefRangeEnd = 792127, XrefRangeStart = 792120, XrefRangeEnd = 792123, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileCoordinate FromWorldPos(float3 pos)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &pos;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCoordinate.NativeMethodInfoPtr_FromWorldPos_Public_Static_TileCoordinate_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileCoordinate*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 792128, RefRangeEnd = 792130, XrefRangeStart = 792127, XrefRangeEnd = 792128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float3 ToWorldPos(TileCoordinate tile)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &tile;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCoordinate.NativeMethodInfoPtr_ToWorldPos_Public_Static_float3_TileCoordinate_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 792133, RefRangeEnd = 792134, XrefRangeStart = 792130, XrefRangeEnd = 792133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileCoordinate FromWorldPos(float2 xz, float y)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &xz;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCoordinate.NativeMethodInfoPtr_FromWorldPos_Public_Static_TileCoordinate_float2_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileCoordinate*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 261679, RefRangeEnd = 261683, XrefRangeStart = 261679, XrefRangeEnd = 261683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(TileCoordinate other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCoordinate.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TileCoordinate_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 792134, RefRangeEnd = 792135, XrefRangeStart = 792134, XrefRangeEnd = 792134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCoordinate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792135, XrefRangeEnd = 792145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TileCoordinate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static TileCoordinate()
    {
      Il2CppClassPointerStore<TileCoordinate>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (TileCoordinate));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileCoordinate>.NativeClassPtr);
      TileCoordinate.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCoordinate>.NativeClassPtr, nameof (X));
      TileCoordinate.NativeFieldInfoPtr_Z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCoordinate>.NativeClassPtr, nameof (Z));
      TileCoordinate.NativeFieldInfoPtr_HeightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCoordinate>.NativeClassPtr, nameof (HeightLevel));
      TileCoordinate.NativeMethodInfoPtr_get_xz_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCoordinate>.NativeClassPtr, 100669700);
      TileCoordinate.NativeMethodInfoPtr__ctor_Public_Void_int2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCoordinate>.NativeClassPtr, 100669701);
      TileCoordinate.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCoordinate>.NativeClassPtr, 100669702);
      TileCoordinate.NativeMethodInfoPtr_op_Addition_Public_Static_TileCoordinate_TileCoordinate_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCoordinate>.NativeClassPtr, 100669703);
      TileCoordinate.NativeMethodInfoPtr_op_Subtraction_Public_Static_TileCoordinate_TileCoordinate_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCoordinate>.NativeClassPtr, 100669704);
      TileCoordinate.NativeMethodInfoPtr_FromWorldPos_Public_Static_TileCoordinate_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCoordinate>.NativeClassPtr, 100669705);
      TileCoordinate.NativeMethodInfoPtr_ToWorldPos_Public_Static_float3_TileCoordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCoordinate>.NativeClassPtr, 100669706);
      TileCoordinate.NativeMethodInfoPtr_FromWorldPos_Public_Static_TileCoordinate_float2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCoordinate>.NativeClassPtr, 100669707);
      TileCoordinate.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TileCoordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCoordinate>.NativeClassPtr, 100669708);
      TileCoordinate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCoordinate>.NativeClassPtr, 100669709);
      TileCoordinate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCoordinate>.NativeClassPtr, 100669710);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileCoordinate>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
