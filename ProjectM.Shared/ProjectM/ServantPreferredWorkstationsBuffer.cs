// Decompiled with JetBrains decompiler
// Type: ProjectM.ServantPreferredWorkstationsBuffer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ServantPreferredWorkstationsBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_PrefabGUID_ServantPreferredWorkstationsBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ServantPreferredWorkstationsBuffer_PrefabGUID_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;

    [CallerCount(504)]
    [CachedScanResults(RefRangeStart = 279526, RefRangeEnd = 280030, XrefRangeStart = 279526, XrefRangeEnd = 280030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator PrefabGUID(ServantPreferredWorkstationsBuffer e)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &e;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantPreferredWorkstationsBuffer.NativeMethodInfoPtr_op_Implicit_Public_Static_PrefabGUID_ServantPreferredWorkstationsBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(504)]
    [CachedScanResults(RefRangeStart = 279526, RefRangeEnd = 280030, XrefRangeStart = 279526, XrefRangeEnd = 280030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator ServantPreferredWorkstationsBuffer(PrefabGUID e)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &e;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantPreferredWorkstationsBuffer.NativeMethodInfoPtr_op_Implicit_Public_Static_ServantPreferredWorkstationsBuffer_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ServantPreferredWorkstationsBuffer*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ServantPreferredWorkstationsBuffer()
    {
      Il2CppClassPointerStore<ServantPreferredWorkstationsBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ServantPreferredWorkstationsBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantPreferredWorkstationsBuffer>.NativeClassPtr);
      ServantPreferredWorkstationsBuffer.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantPreferredWorkstationsBuffer>.NativeClassPtr, nameof (PrefabGuid));
      ServantPreferredWorkstationsBuffer.NativeMethodInfoPtr_op_Implicit_Public_Static_PrefabGUID_ServantPreferredWorkstationsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantPreferredWorkstationsBuffer>.NativeClassPtr, 100667465);
      ServantPreferredWorkstationsBuffer.NativeMethodInfoPtr_op_Implicit_Public_Static_ServantPreferredWorkstationsBuffer_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantPreferredWorkstationsBuffer>.NativeClassPtr, 100667466);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantPreferredWorkstationsBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
