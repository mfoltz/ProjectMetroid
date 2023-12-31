// Decompiled with JetBrains decompiler
// Type: ProjectM.Debugging.GameplayDebugging
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Debugging
{
  public static class GameplayDebugging : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__IsEnabled_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnEnabledChanged;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsEnabled_Public_Static_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IsEnabled_Private_Static_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_add_OnEnabledChanged_Public_Static_add_Void_Action_1_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnEnabledChanged_Public_Static_rem_Void_Action_1_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Enable_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Disable_Public_Static_Void_0;

    public static unsafe bool IsEnabled
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770000, XrefRangeEnd = 770002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayDebugging.NativeMethodInfoPtr_get_IsEnabled_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770002, XrefRangeEnd = 770004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameplayDebugging.NativeMethodInfoPtr_set_IsEnabled_Private_Static_set_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770004, XrefRangeEnd = 770011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public static unsafe void add_OnEnabledChanged(Il2CppSystem.Action<bool> value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayDebugging.NativeMethodInfoPtr_add_OnEnabledChanged_Public_Static_add_Void_Action_1_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770011, XrefRangeEnd = 770018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public static unsafe void remove_OnEnabledChanged(Il2CppSystem.Action<bool> value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayDebugging.NativeMethodInfoPtr_remove_OnEnabledChanged_Public_Static_rem_Void_Action_1_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 770027, RefRangeEnd = 770028, XrefRangeStart = 770018, XrefRangeEnd = 770027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Enable()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayDebugging.NativeMethodInfoPtr_Enable_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770028, XrefRangeEnd = 770037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Disable()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayDebugging.NativeMethodInfoPtr_Disable_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GameplayDebugging()
    {
      Il2CppClassPointerStore<GameplayDebugging>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Debugging", nameof (GameplayDebugging));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayDebugging>.NativeClassPtr);
      GameplayDebugging.NativeFieldInfoPtr__IsEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayDebugging>.NativeClassPtr, "<IsEnabled>k__BackingField");
      GameplayDebugging.NativeFieldInfoPtr_OnEnabledChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayDebugging>.NativeClassPtr, nameof (OnEnabledChanged));
      GameplayDebugging.NativeMethodInfoPtr_get_IsEnabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayDebugging>.NativeClassPtr, 100668166);
      GameplayDebugging.NativeMethodInfoPtr_set_IsEnabled_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayDebugging>.NativeClassPtr, 100668167);
      GameplayDebugging.NativeMethodInfoPtr_add_OnEnabledChanged_Public_Static_add_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayDebugging>.NativeClassPtr, 100668168);
      GameplayDebugging.NativeMethodInfoPtr_remove_OnEnabledChanged_Public_Static_rem_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayDebugging>.NativeClassPtr, 100668169);
      GameplayDebugging.NativeMethodInfoPtr_Enable_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayDebugging>.NativeClassPtr, 100668170);
      GameplayDebugging.NativeMethodInfoPtr_Disable_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayDebugging>.NativeClassPtr, 100668171);
    }

    public GameplayDebugging(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe bool _IsEnabled_k__BackingField
    {
      get
      {
        bool enabledKBackingField;
        IL2CPP.il2cpp_field_static_get_value(GameplayDebugging.NativeFieldInfoPtr__IsEnabled_k__BackingField, (void*) &enabledKBackingField);
        return enabledKBackingField;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameplayDebugging.NativeFieldInfoPtr__IsEnabled_k__BackingField, (void*) &value);
      }
    }

    public static unsafe Il2CppSystem.Action<bool> OnEnabledChanged
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(GameplayDebugging.NativeFieldInfoPtr_OnEnabledChanged, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<bool>) null : new Il2CppSystem.Action<bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameplayDebugging.NativeFieldInfoPtr_OnEnabledChanged, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
