// Decompiled with JetBrains decompiler
// Type: ProjectM.PrefabSetBuffer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PrefabSetBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGUID;
    private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Public_Static_Boolean_byref_DynamicBuffer_1_PrefabSetBuffer_PrefabGUID_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGUID;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 747480, RefRangeEnd = 747481, XrefRangeStart = 747471, XrefRangeEnd = 747480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool Contains(
      [In] ref DynamicBuffer<PrefabSetBuffer> prefabSetBuffer,
      PrefabGUID prefabGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref prefabSetBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabSetBuffer.NativeMethodInfoPtr_Contains_Public_Static_Boolean_byref_DynamicBuffer_1_PrefabSetBuffer_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static PrefabSetBuffer()
    {
      Il2CppClassPointerStore<PrefabSetBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (PrefabSetBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabSetBuffer>.NativeClassPtr);
      PrefabSetBuffer.NativeFieldInfoPtr_PrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabSetBuffer>.NativeClassPtr, nameof (PrefabGUID));
      PrefabSetBuffer.NativeMethodInfoPtr_Contains_Public_Static_Boolean_byref_DynamicBuffer_1_PrefabSetBuffer_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabSetBuffer>.NativeClassPtr, 100665822);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabSetBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
