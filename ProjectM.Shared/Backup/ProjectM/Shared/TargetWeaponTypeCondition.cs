// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.TargetWeaponTypeCondition
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TargetWeaponTypeCondition
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Fields;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_Invert;
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConditionalAuthoring_0;
    [FieldOffset(0)]
    public readonly ConditionTarget Target;
    [FieldOffset(4)]
    public readonly bool Invert;
    [FieldOffset(8)]
    public readonly WeaponType Value;

    [CallerCount(0)]
    public unsafe TargetWeaponTypeCondition(ConditionalAuthoring authoring)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) authoring);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TargetWeaponTypeCondition.NativeMethodInfoPtr__ctor_Public_Void_ConditionalAuthoring_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TargetWeaponTypeCondition()
    {
      Il2CppClassPointerStore<TargetWeaponTypeCondition>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (TargetWeaponTypeCondition));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetWeaponTypeCondition>.NativeClassPtr);
      TargetWeaponTypeCondition.NativeFieldInfoPtr_Fields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetWeaponTypeCondition>.NativeClassPtr, nameof (Fields));
      TargetWeaponTypeCondition.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetWeaponTypeCondition>.NativeClassPtr, nameof (Target));
      TargetWeaponTypeCondition.NativeFieldInfoPtr_Invert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetWeaponTypeCondition>.NativeClassPtr, nameof (Invert));
      TargetWeaponTypeCondition.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetWeaponTypeCondition>.NativeClassPtr, nameof (Value));
      TargetWeaponTypeCondition.NativeMethodInfoPtr__ctor_Public_Void_ConditionalAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetWeaponTypeCondition>.NativeClassPtr, 100670621);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TargetWeaponTypeCondition>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe ConditionDataFields Fields
    {
      get
      {
        ConditionDataFields fields;
        IL2CPP.il2cpp_field_static_get_value(TargetWeaponTypeCondition.NativeFieldInfoPtr_Fields, (void*) &fields);
        return fields;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TargetWeaponTypeCondition.NativeFieldInfoPtr_Fields, (void*) &value);
      }
    }
  }
}
