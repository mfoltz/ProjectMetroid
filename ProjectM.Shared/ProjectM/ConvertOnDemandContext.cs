// Decompiled with JetBrains decompiler
// Type: ProjectM.ConvertOnDemandContext
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ConvertOnDemandContext
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabLookupMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewRequiredPrefabs;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddPrefabToConvert_Public_Boolean_PrefabGUID_0;
    [FieldOffset(0)]
    public PrefabLookupMap PrefabLookupMap;
    [FieldOffset(48)]
    public NativeHashSet<PrefabGUID> NewRequiredPrefabs;

    [CallerCount(20)]
    [CachedScanResults(RefRangeStart = 756960, RefRangeEnd = 756980, XrefRangeStart = 756951, XrefRangeEnd = 756960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool AddPrefabToConvert(PrefabGUID prefabGUID)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &prefabGUID;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConvertOnDemandContext.NativeMethodInfoPtr_AddPrefabToConvert_Public_Boolean_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ConvertOnDemandContext()
    {
      Il2CppClassPointerStore<ConvertOnDemandContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ConvertOnDemandContext));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConvertOnDemandContext>.NativeClassPtr);
      ConvertOnDemandContext.NativeFieldInfoPtr_PrefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConvertOnDemandContext>.NativeClassPtr, nameof (PrefabLookupMap));
      ConvertOnDemandContext.NativeFieldInfoPtr_NewRequiredPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConvertOnDemandContext>.NativeClassPtr, nameof (NewRequiredPrefabs));
      ConvertOnDemandContext.NativeMethodInfoPtr_AddPrefabToConvert_Public_Boolean_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConvertOnDemandContext>.NativeClassPtr, 100666828);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConvertOnDemandContext>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
