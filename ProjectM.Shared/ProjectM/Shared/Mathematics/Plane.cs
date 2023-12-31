// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.Mathematics.Plane
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Shared.Mathematics
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Plane
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Distance;
    private static readonly System.IntPtr NativeFieldInfoPtr_Normal;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_float4_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_float3_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_float3_float3_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dot_Public_Double_float4_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dot_Public_Void_byref_float4_byref_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DotCoordinate_Public_Double_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DotCoordinate_Public_Void_byref_float3_byref_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DotNormal_Public_Double_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DotNormal_Public_Void_byref_float3_byref_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Normalize_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Normalize_Public_Static_Plane_Plane_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Normalize_Public_Static_Void_byref_Plane_byref_Plane_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Plane_Plane_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Plane_Plane_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Plane_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromNormalAndPosition_Public_Static_Plane_float3_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Boolean_Ray_byref_Single_0;
    [FieldOffset(0)]
    public float Distance;
    [FieldOffset(4)]
    public float3 Normal;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803470, XrefRangeEnd = 803471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Plane(float4 value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr__ctor_Public_Void_float4_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 803472, RefRangeEnd = 803478, XrefRangeStart = 803471, XrefRangeEnd = 803472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Plane(float3 normal, float d)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &normal;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr__ctor_Public_Void_float3_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803478, XrefRangeEnd = 803480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Plane(float3 a, float3 b, float3 c)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr__ctor_Public_Void_float3_float3_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803480, XrefRangeEnd = 803481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Plane(float a, float b, float c, float d)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe double Dot(float4 value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_Dot_Public_Double_float4_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void Dot(ref float4 value, out float result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_Dot_Public_Void_byref_float4_byref_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe double DotCoordinate(float3 value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_DotCoordinate_Public_Double_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void DotCoordinate(ref float3 value, out float result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_DotCoordinate_Public_Void_byref_float3_byref_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe double DotNormal(float3 value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_DotNormal_Public_Double_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void DotNormal(ref float3 value, out float result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_DotNormal_Public_Void_byref_float3_byref_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803481, XrefRangeEnd = 803489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Normalize()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_Normalize_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803489, XrefRangeEnd = 803490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Plane Normalize(Plane value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_Normalize_Public_Static_Plane_Plane_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Plane*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 803498, RefRangeEnd = 803499, XrefRangeStart = 803490, XrefRangeEnd = 803498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Normalize(ref Plane value, out Plane result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_Normalize_Public_Static_Void_byref_Plane_byref_Plane_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public static unsafe bool operator !=(Plane plane1, Plane plane2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &plane1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &plane2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Plane_Plane_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool operator ==(Plane plane1, Plane plane2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &plane1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &plane2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Plane_Plane_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803499, XrefRangeEnd = 803502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public virtual unsafe bool Equals(Plane other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Plane_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803502, XrefRangeEnd = 803503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803503, XrefRangeEnd = 803512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 803513, RefRangeEnd = 803514, XrefRangeStart = 803512, XrefRangeEnd = 803513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Plane FromNormalAndPosition(float3 normal, float3 pointOnPlane)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &normal;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pointOnPlane;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_FromNormalAndPosition_Public_Static_Plane_float3_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Plane*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 803521, RefRangeEnd = 803525, XrefRangeStart = 803514, XrefRangeEnd = 803521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Raycast(Ray ray, out float enter)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &ray;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref enter;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_Raycast_Public_Boolean_Ray_byref_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static Plane()
    {
      Il2CppClassPointerStore<Plane>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared.Mathematics", nameof (Plane));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Plane>.NativeClassPtr);
      Plane.NativeFieldInfoPtr_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plane>.NativeClassPtr, nameof (Distance));
      Plane.NativeFieldInfoPtr_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plane>.NativeClassPtr, nameof (Normal));
      Plane.NativeMethodInfoPtr__ctor_Public_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100670855);
      Plane.NativeMethodInfoPtr__ctor_Public_Void_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100670856);
      Plane.NativeMethodInfoPtr__ctor_Public_Void_float3_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100670857);
      Plane.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100670858);
      Plane.NativeMethodInfoPtr_Dot_Public_Double_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100670859);
      Plane.NativeMethodInfoPtr_Dot_Public_Void_byref_float4_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100670860);
      Plane.NativeMethodInfoPtr_DotCoordinate_Public_Double_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100670861);
      Plane.NativeMethodInfoPtr_DotCoordinate_Public_Void_byref_float3_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100670862);
      Plane.NativeMethodInfoPtr_DotNormal_Public_Double_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100670863);
      Plane.NativeMethodInfoPtr_DotNormal_Public_Void_byref_float3_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100670864);
      Plane.NativeMethodInfoPtr_Normalize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100670865);
      Plane.NativeMethodInfoPtr_Normalize_Public_Static_Plane_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100670866);
      Plane.NativeMethodInfoPtr_Normalize_Public_Static_Void_byref_Plane_byref_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100670867);
      Plane.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Plane_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100670868);
      Plane.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Plane_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100670869);
      Plane.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100670870);
      Plane.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100670871);
      Plane.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100670872);
      Plane.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100670873);
      Plane.NativeMethodInfoPtr_FromNormalAndPosition_Public_Static_Plane_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100670874);
      Plane.NativeMethodInfoPtr_Raycast_Public_Boolean_Ray_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100670875);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Plane>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
