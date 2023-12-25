// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.ConditionEvaluator
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Behaviours
{
  public static class ConditionEvaluator : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Instant_Public_Static_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_byref_TCondition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Monitor_Public_Static_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_byref_TCondition_Boolean_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1342775, RefRangeEnd = 1342776, XrefRangeStart = 1342774, XrefRangeEnd = 1342775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeResult Instant<TCondition>(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData,
      [In] ref TCondition condition)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) condition);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConditionEvaluator.MethodInfoStoreGeneric_Instant_Public_Static_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_byref_TCondition_0<TCondition>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TCondition local = ref condition;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TCondition>(objectPointer, false, false);
      local = (TCondition) valueGeneric;
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1342777, RefRangeEnd = 1342778, XrefRangeStart = 1342776, XrefRangeEnd = 1342777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeResult Monitor<TCondition>(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData,
      [In] ref TCondition condition,
      bool invert)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
      numPtr1[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) condition);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &invert;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConditionEvaluator.MethodInfoStoreGeneric_Monitor_Public_Static_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_byref_TCondition_Boolean_0<TCondition>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TCondition local = ref condition;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TCondition>(objectPointer, false, false);
      local = (TCondition) valueGeneric;
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num2);
    }

    static ConditionEvaluator()
    {
      Il2CppClassPointerStore<ConditionEvaluator>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (ConditionEvaluator));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionEvaluator>.NativeClassPtr);
      ConditionEvaluator.NativeMethodInfoPtr_Instant_Public_Static_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_byref_TCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionEvaluator>.NativeClassPtr, 100665271);
      ConditionEvaluator.NativeMethodInfoPtr_Monitor_Public_Static_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_byref_TCondition_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionEvaluator>.NativeClassPtr, 100665272);
    }

    public ConditionEvaluator(System.IntPtr pointer)
      : base(pointer)
    {
    }

    private sealed class MethodInfoStoreGeneric_Instant_Public_Static_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_byref_TCondition_0<TCondition>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ConditionEvaluator.NativeMethodInfoPtr_Instant_Public_Static_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_byref_TCondition_0, Il2CppClassPointerStore<ConditionEvaluator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCondition>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Monitor_Public_Static_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_byref_TCondition_Boolean_0<TCondition>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ConditionEvaluator.NativeMethodInfoPtr_Monitor_Public_Static_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_byref_TCondition_Boolean_0, Il2CppClassPointerStore<ConditionEvaluator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCondition>.NativeClassPtr))
      }))));
    }
  }
}
