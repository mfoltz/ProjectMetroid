// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Buff_EmpowerDamageDealtByType_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Scripting;
using ProjectM.Shared;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Buff_EmpowerDamageDealtByType_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageFactorPerStack;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnDamageDealtListener;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageType;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0;
    [FieldOffset(0)]
    public float DamageFactor;
    [FieldOffset(4)]
    public float DamageFactorPerStack;
    [FieldOffset(8)]
    public ListenerId OnDamageDealtListener;
    [FieldOffset(16)]
    public MainDamageType DamageType;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182688, XrefRangeEnd = 1182693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ApplyArithmetic(SpellModArithmetic spellMod, float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &spellMod;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Buff_EmpowerDamageDealtByType_DataShared.NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Buff_EmpowerDamageDealtByType_DataShared()
    {
      Il2CppClassPointerStore<Buff_EmpowerDamageDealtByType_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Buff_EmpowerDamageDealtByType_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Buff_EmpowerDamageDealtByType_DataShared>.NativeClassPtr);
      Buff_EmpowerDamageDealtByType_DataShared.NativeFieldInfoPtr_DamageFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_EmpowerDamageDealtByType_DataShared>.NativeClassPtr, nameof (DamageFactor));
      Buff_EmpowerDamageDealtByType_DataShared.NativeFieldInfoPtr_DamageFactorPerStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_EmpowerDamageDealtByType_DataShared>.NativeClassPtr, nameof (DamageFactorPerStack));
      Buff_EmpowerDamageDealtByType_DataShared.NativeFieldInfoPtr_OnDamageDealtListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_EmpowerDamageDealtByType_DataShared>.NativeClassPtr, nameof (OnDamageDealtListener));
      Buff_EmpowerDamageDealtByType_DataShared.NativeFieldInfoPtr_DamageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_EmpowerDamageDealtByType_DataShared>.NativeClassPtr, nameof (DamageType));
      Buff_EmpowerDamageDealtByType_DataShared.NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buff_EmpowerDamageDealtByType_DataShared>.NativeClassPtr, 100664170);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Buff_EmpowerDamageDealtByType_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
