// Decompiled with JetBrains decompiler
// Type: ProjectM.AmplifyBuff
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AmplifyBuff
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AmplifyModifier;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0;
    [FieldOffset(0)]
    public float AmplifyModifier;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723618, XrefRangeEnd = 723624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ApplyArithmetic(SpellModArithmetic spellMod, float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &spellMod;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AmplifyBuff.NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AmplifyBuff()
    {
      Il2CppClassPointerStore<AmplifyBuff>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AmplifyBuff));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmplifyBuff>.NativeClassPtr);
      AmplifyBuff.NativeFieldInfoPtr_AmplifyModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyBuff>.NativeClassPtr, nameof (AmplifyModifier));
      AmplifyBuff.NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyBuff>.NativeClassPtr, 100663976);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AmplifyBuff>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
