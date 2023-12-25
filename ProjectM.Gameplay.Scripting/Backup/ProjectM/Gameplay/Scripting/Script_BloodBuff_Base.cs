// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_BloodBuff_Base
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Scripting;
using System;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class Script_BloodBuff_Base : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeMethodInfoPtr_GetLerpedValue_Public_Static_Single_Single_Single_Single_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(73)]
    [CachedScanResults(RefRangeStart = 1179970, RefRangeEnd = 1180043, XrefRangeStart = 1179970, XrefRangeEnd = 1179970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetLerpedValue(
      float bloodQuality,
      float requiredBloodQuality,
      float minValue,
      float maxValue)
    {
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = (IntPtr) &bloodQuality;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &requiredBloodQuality;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &minValue;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &maxValue;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(Script_BloodBuff_Base.NativeMethodInfoPtr_GetLerpedValue_Public_Static_Single_Single_Single_Single_Single_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_BloodBuff_Base()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_BloodBuff_Base>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_BloodBuff_Base.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_BloodBuff_Base()
    {
      Il2CppClassPointerStore<Script_BloodBuff_Base>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_BloodBuff_Base));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_BloodBuff_Base>.NativeClassPtr);
      Script_BloodBuff_Base.NativeMethodInfoPtr_GetLerpedValue_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BloodBuff_Base>.NativeClassPtr, 100663884);
      Script_BloodBuff_Base.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BloodBuff_Base>.NativeClassPtr, 100663885);
    }

    public Script_BloodBuff_Base(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
