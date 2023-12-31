// Decompiled with JetBrains decompiler
// Type: ProjectM.BlueprintUtilities
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class BlueprintUtilities : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCanCraftAmount_Public_Static_Int32_EntityManager_Entity_NativeArray_1_BlueprintRequirementBuffer_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 723665, RefRangeEnd = 723666, XrefRangeStart = 723660, XrefRangeEnd = 723665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetCanCraftAmount(
      EntityManager entityManager,
      Entity character,
      NativeArray<BlueprintRequirementBuffer> requirements)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &requirements;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BlueprintUtilities.NativeMethodInfoPtr_GetCanCraftAmount_Public_Static_Int32_EntityManager_Entity_NativeArray_1_BlueprintRequirementBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static BlueprintUtilities()
    {
      Il2CppClassPointerStore<BlueprintUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BlueprintUtilities));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlueprintUtilities>.NativeClassPtr);
      BlueprintUtilities.NativeMethodInfoPtr_GetCanCraftAmount_Public_Static_Int32_EntityManager_Entity_NativeArray_1_BlueprintRequirementBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintUtilities>.NativeClassPtr, 100663982);
    }

    public BlueprintUtilities(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
