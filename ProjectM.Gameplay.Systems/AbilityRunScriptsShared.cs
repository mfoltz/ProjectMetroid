// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityRunScriptsShared
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class AbilityRunScriptsShared : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSlotIndex_Public_Static_Int32_EntityManager_Entity_Entity_0;

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 1369888, RefRangeEnd = 1369897, XrefRangeStart = 1369873, XrefRangeEnd = 1369888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetSlotIndex(
      EntityManager entityManager,
      Entity character,
      Entity abilityGroup)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroup;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityRunScriptsShared.NativeMethodInfoPtr_GetSlotIndex_Public_Static_Int32_EntityManager_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AbilityRunScriptsShared()
    {
      Il2CppClassPointerStore<AbilityRunScriptsShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (AbilityRunScriptsShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityRunScriptsShared>.NativeClassPtr);
      AbilityRunScriptsShared.NativeMethodInfoPtr_GetSlotIndex_Public_Static_Int32_EntityManager_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRunScriptsShared>.NativeClassPtr, 100664332);
    }

    public AbilityRunScriptsShared(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
