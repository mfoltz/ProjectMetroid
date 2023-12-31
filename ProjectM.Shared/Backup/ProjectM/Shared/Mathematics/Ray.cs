// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.Mathematics.Ray
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Shared.Mathematics
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct Ray
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Direction;
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_float3_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Ray_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Intersects_Public_Boolean_Plane_byref_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPoint_Public_float3_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Ray_Ray_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Ray_Ray_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    [FieldOffset(0)]
    public float3 Direction;
    [FieldOffset(12)]
    public float3 Position;

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 803525, RefRangeEnd = 803530, XrefRangeStart = 803525, XrefRangeEnd = 803525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Ray(float3 position, float3 direction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr__ctor_Public_Void_float3_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803530, XrefRangeEnd = 803533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public virtual unsafe bool Equals(Ray other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Ray_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803533, XrefRangeEnd = 803537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Intersects(Plane plane, out float distance)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &plane;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref distance;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr_Intersects_Public_Boolean_Plane_byref_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 803537, RefRangeEnd = 803540, XrefRangeStart = 803537, XrefRangeEnd = 803537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float3 GetPoint(float distance)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &distance;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr_GetPoint_Public_float3_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool operator !=(Ray a, Ray b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Ray_Ray_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool operator ==(Ray a, Ray b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Ray_Ray_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803540, XrefRangeEnd = 803545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static Ray()
    {
      Il2CppClassPointerStore<Ray>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared.Mathematics", nameof (Ray));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ray>.NativeClassPtr);
      Ray.NativeFieldInfoPtr_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ray>.NativeClassPtr, nameof (Direction));
      Ray.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ray>.NativeClassPtr, nameof (Position));
      Ray.NativeMethodInfoPtr__ctor_Public_Void_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100670876);
      Ray.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100670877);
      Ray.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100670878);
      Ray.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100670879);
      Ray.NativeMethodInfoPtr_Intersects_Public_Boolean_Plane_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100670880);
      Ray.NativeMethodInfoPtr_GetPoint_Public_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100670881);
      Ray.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Ray_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100670882);
      Ray.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Ray_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100670883);
      Ray.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100670884);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Ray>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
