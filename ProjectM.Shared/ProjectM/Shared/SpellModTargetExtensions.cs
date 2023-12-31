// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.SpellModTargetExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace ProjectM.Shared
{
  public static class SpellModTargetExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_CompareAgainstGameplayEventEnum_Public_Static_Boolean_SpellModArithmeticTarget_GameplayEventTypeEnum_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AsGameplayEventEnum_Public_Static_GameplayEventTypeEnum_SpellModArithmeticTarget_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CompareAgainstGameplayEventEnum_Public_Static_Boolean_SpellModPrefabGuidTarget_GameplayEventTypeEnum_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AsGameplayEventEnum_Public_Static_GameplayEventTypeEnum_SpellModPrefabGuidTarget_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CompareAgainstGameplayEventEnum_Public_Static_Boolean_SpellModSequenceGuidTarget_GameplayEventTypeEnum_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AsGameplayEventEnum_Public_Static_GameplayEventTypeEnum_SpellModSequenceGuidTarget_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 799442, RefRangeEnd = 799443, XrefRangeStart = 799441, XrefRangeEnd = 799442, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CompareAgainstGameplayEventEnum(
      this SpellModArithmeticTarget target,
      GameplayEventTypeEnum gameplayEventType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &gameplayEventType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModTargetExtensions.NativeMethodInfoPtr_CompareAgainstGameplayEventEnum_Public_Static_Boolean_SpellModArithmeticTarget_GameplayEventTypeEnum_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 799443, RefRangeEnd = 799444, XrefRangeStart = 799443, XrefRangeEnd = 799443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe GameplayEventTypeEnum AsGameplayEventEnum(
      this SpellModArithmeticTarget target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &target;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModTargetExtensions.NativeMethodInfoPtr_AsGameplayEventEnum_Public_Static_GameplayEventTypeEnum_SpellModArithmeticTarget_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GameplayEventTypeEnum*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 799444, RefRangeEnd = 799445, XrefRangeStart = 799444, XrefRangeEnd = 799444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CompareAgainstGameplayEventEnum(
      this SpellModPrefabGuidTarget target,
      GameplayEventTypeEnum gameplayEventType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &gameplayEventType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModTargetExtensions.NativeMethodInfoPtr_CompareAgainstGameplayEventEnum_Public_Static_Boolean_SpellModPrefabGuidTarget_GameplayEventTypeEnum_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe GameplayEventTypeEnum AsGameplayEventEnum(
      this SpellModPrefabGuidTarget target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &target;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModTargetExtensions.NativeMethodInfoPtr_AsGameplayEventEnum_Public_Static_GameplayEventTypeEnum_SpellModPrefabGuidTarget_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GameplayEventTypeEnum*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 799445, RefRangeEnd = 799446, XrefRangeStart = 799445, XrefRangeEnd = 799445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CompareAgainstGameplayEventEnum(
      this SpellModSequenceGuidTarget target,
      GameplayEventTypeEnum gameplayEventType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &gameplayEventType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModTargetExtensions.NativeMethodInfoPtr_CompareAgainstGameplayEventEnum_Public_Static_Boolean_SpellModSequenceGuidTarget_GameplayEventTypeEnum_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe GameplayEventTypeEnum AsGameplayEventEnum(
      this SpellModSequenceGuidTarget target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &target;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModTargetExtensions.NativeMethodInfoPtr_AsGameplayEventEnum_Public_Static_GameplayEventTypeEnum_SpellModSequenceGuidTarget_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GameplayEventTypeEnum*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SpellModTargetExtensions()
    {
      Il2CppClassPointerStore<SpellModTargetExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (SpellModTargetExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellModTargetExtensions>.NativeClassPtr);
      SpellModTargetExtensions.NativeMethodInfoPtr_CompareAgainstGameplayEventEnum_Public_Static_Boolean_SpellModArithmeticTarget_GameplayEventTypeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModTargetExtensions>.NativeClassPtr, 100670544);
      SpellModTargetExtensions.NativeMethodInfoPtr_AsGameplayEventEnum_Public_Static_GameplayEventTypeEnum_SpellModArithmeticTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModTargetExtensions>.NativeClassPtr, 100670545);
      SpellModTargetExtensions.NativeMethodInfoPtr_CompareAgainstGameplayEventEnum_Public_Static_Boolean_SpellModPrefabGuidTarget_GameplayEventTypeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModTargetExtensions>.NativeClassPtr, 100670546);
      SpellModTargetExtensions.NativeMethodInfoPtr_AsGameplayEventEnum_Public_Static_GameplayEventTypeEnum_SpellModPrefabGuidTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModTargetExtensions>.NativeClassPtr, 100670547);
      SpellModTargetExtensions.NativeMethodInfoPtr_CompareAgainstGameplayEventEnum_Public_Static_Boolean_SpellModSequenceGuidTarget_GameplayEventTypeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModTargetExtensions>.NativeClassPtr, 100670548);
      SpellModTargetExtensions.NativeMethodInfoPtr_AsGameplayEventEnum_Public_Static_GameplayEventTypeEnum_SpellModSequenceGuidTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModTargetExtensions>.NativeClassPtr, 100670549);
    }

    public SpellModTargetExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
