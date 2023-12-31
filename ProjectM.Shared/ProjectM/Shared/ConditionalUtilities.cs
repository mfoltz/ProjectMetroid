// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.ConditionalUtilities
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace ProjectM.Shared
{
  public static class ConditionalUtilities : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetInvertState_Public_Static_Boolean_GameplayConditionComponentData_Editor_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetInvertState_Public_Static_Boolean_ConditionSource_ConditionTypes_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetInvertState_Public_Static_Boolean_ConditionTypes_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsBoolExposedInEditor_Public_Static_Boolean_ConditionSource_0;

    [CallerCount(0)]
    public static unsafe bool GetInvertState(GameplayConditionComponentData_Editor condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) condition);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionalUtilities.NativeMethodInfoPtr_GetInvertState_Public_Static_Boolean_GameplayConditionComponentData_Editor_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool GetInvertState(
      ConditionSource conditionSource,
      ConditionTypes conditionType,
      bool boolValue)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &conditionSource;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &conditionType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &boolValue;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionalUtilities.NativeMethodInfoPtr_GetInvertState_Public_Static_Boolean_ConditionSource_ConditionTypes_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool GetInvertState(ConditionTypes conditionType, bool boolValue)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &conditionType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &boolValue;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionalUtilities.NativeMethodInfoPtr_GetInvertState_Public_Static_Boolean_ConditionTypes_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool IsBoolExposedInEditor(ConditionSource conditionSource)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &conditionSource;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionalUtilities.NativeMethodInfoPtr_IsBoolExposedInEditor_Public_Static_Boolean_ConditionSource_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ConditionalUtilities()
    {
      Il2CppClassPointerStore<ConditionalUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (ConditionalUtilities));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionalUtilities>.NativeClassPtr);
      ConditionalUtilities.NativeMethodInfoPtr_GetInvertState_Public_Static_Boolean_GameplayConditionComponentData_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalUtilities>.NativeClassPtr, 100670579);
      ConditionalUtilities.NativeMethodInfoPtr_GetInvertState_Public_Static_Boolean_ConditionSource_ConditionTypes_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalUtilities>.NativeClassPtr, 100670580);
      ConditionalUtilities.NativeMethodInfoPtr_GetInvertState_Public_Static_Boolean_ConditionTypes_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalUtilities>.NativeClassPtr, 100670581);
      ConditionalUtilities.NativeMethodInfoPtr_IsBoolExposedInEditor_Public_Static_Boolean_ConditionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalUtilities>.NativeClassPtr, 100670582);
    }

    public ConditionalUtilities(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
