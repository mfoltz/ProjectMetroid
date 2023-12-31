// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.Mathematics.PlaneHelper
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Shared.Mathematics
{
  public class PlaneHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ClassifyPoint_Public_Static_Double_byref_float3_byref_Plane_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PerpendicularDistance_Public_Static_Double_byref_float3_byref_Plane_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    public static unsafe double ClassifyPoint(ref float3 point, ref Plane plane)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref point;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref plane;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaneHelper.NativeMethodInfoPtr_ClassifyPoint_Public_Static_Double_byref_float3_byref_Plane_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803465, XrefRangeEnd = 803470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe double PerpendicularDistance(ref float3 point, ref Plane plane)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref point;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref plane;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlaneHelper.NativeMethodInfoPtr_PerpendicularDistance_Public_Static_Double_byref_float3_byref_Plane_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlaneHelper()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaneHelper>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaneHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PlaneHelper()
    {
      Il2CppClassPointerStore<PlaneHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared.Mathematics", nameof (PlaneHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaneHelper>.NativeClassPtr);
      PlaneHelper.NativeMethodInfoPtr_ClassifyPoint_Public_Static_Double_byref_float3_byref_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneHelper>.NativeClassPtr, 100670852);
      PlaneHelper.NativeMethodInfoPtr_PerpendicularDistance_Public_Static_Double_byref_float3_byref_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneHelper>.NativeClassPtr, 100670853);
      PlaneHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneHelper>.NativeClassPtr, 100670854);
    }

    public PlaneHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
