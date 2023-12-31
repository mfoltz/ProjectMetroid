// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.Mathematics.MathExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Shared.Mathematics
{
  public static class MathExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_FromHeight_Public_Static_Ray_byref_Ray_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromHeightLevel_Public_Static_Ray_byref_Ray_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromHeightLevel_Public_Static_Ray_byref_Ray_Single_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803453, XrefRangeEnd = 803455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Ray FromHeight([In] ref this Ray ray, float height)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref ray;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MathExtensions.NativeMethodInfoPtr_FromHeight_Public_Static_Ray_byref_Ray_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Ray*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803455, XrefRangeEnd = 803458, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Ray FromHeightLevel([In] ref this Ray ray, byte heightLevel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref ray;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MathExtensions.NativeMethodInfoPtr_FromHeightLevel_Public_Static_Ray_byref_Ray_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Ray*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 803462, RefRangeEnd = 803465, XrefRangeStart = 803458, XrefRangeEnd = 803462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Ray FromHeightLevel([In] ref this Ray ray, float position)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref ray;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MathExtensions.NativeMethodInfoPtr_FromHeightLevel_Public_Static_Ray_byref_Ray_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Ray*) IL2CPP.il2cpp_object_unbox(num);
    }

    static MathExtensions()
    {
      Il2CppClassPointerStore<MathExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared.Mathematics", nameof (MathExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MathExtensions>.NativeClassPtr);
      MathExtensions.NativeMethodInfoPtr_FromHeight_Public_Static_Ray_byref_Ray_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathExtensions>.NativeClassPtr, 100670849);
      MathExtensions.NativeMethodInfoPtr_FromHeightLevel_Public_Static_Ray_byref_Ray_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathExtensions>.NativeClassPtr, 100670850);
      MathExtensions.NativeMethodInfoPtr_FromHeightLevel_Public_Static_Ray_byref_Ray_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathExtensions>.NativeClassPtr, 100670851);
    }

    public MathExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
