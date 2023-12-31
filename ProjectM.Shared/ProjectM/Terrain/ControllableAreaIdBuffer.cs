// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.ControllableAreaIdBuffer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Terrain
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ControllableAreaIdBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AreaId;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ControllableAreaIdBuffer_ControllableAreaId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ControllableAreaId_ControllableAreaIdBuffer_0;
    [FieldOffset(0)]
    public ControllableAreaId AreaId;

    [CallerCount(59)]
    [CachedScanResults(RefRangeStart = 562577, RefRangeEnd = 562636, XrefRangeStart = 562577, XrefRangeEnd = 562636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator ControllableAreaIdBuffer(ControllableAreaId e)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &e;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ControllableAreaIdBuffer.NativeMethodInfoPtr_op_Implicit_Public_Static_ControllableAreaIdBuffer_ControllableAreaId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ControllableAreaIdBuffer*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(59)]
    [CachedScanResults(RefRangeStart = 562577, RefRangeEnd = 562636, XrefRangeStart = 562577, XrefRangeEnd = 562636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator ControllableAreaId(ControllableAreaIdBuffer e)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &e;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ControllableAreaIdBuffer.NativeMethodInfoPtr_op_Implicit_Public_Static_ControllableAreaId_ControllableAreaIdBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ControllableAreaId*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ControllableAreaIdBuffer()
    {
      Il2CppClassPointerStore<ControllableAreaIdBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (ControllableAreaIdBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllableAreaIdBuffer>.NativeClassPtr);
      ControllableAreaIdBuffer.NativeFieldInfoPtr_AreaId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllableAreaIdBuffer>.NativeClassPtr, nameof (AreaId));
      ControllableAreaIdBuffer.NativeMethodInfoPtr_op_Implicit_Public_Static_ControllableAreaIdBuffer_ControllableAreaId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllableAreaIdBuffer>.NativeClassPtr, 100667770);
      ControllableAreaIdBuffer.NativeMethodInfoPtr_op_Implicit_Public_Static_ControllableAreaId_ControllableAreaIdBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllableAreaIdBuffer>.NativeClassPtr, 100667771);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControllableAreaIdBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
