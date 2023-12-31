// Decompiled with JetBrains decompiler
// Type: ProjectM.ServantPower
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ServantPower
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GearLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_Profficiency;
    private static readonly System.IntPtr NativeFieldInfoPtr_Power;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPower_Public_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPower_Public_Static_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHuntProficiency_Public_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHuntProficiency_Public_Static_Single_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLootFactor_Public_Single_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHealthBonusFactor_Public_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDamageBonusFactor_Public_Single_0;
    [FieldOffset(0)]
    public float GearLevel;
    [FieldOffset(4)]
    public float Profficiency;
    [FieldOffset(8)]
    public float Power;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 740704, RefRangeEnd = 740706, XrefRangeStart = 740703, XrefRangeEnd = 740704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetPower()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantPower.NativeMethodInfoPtr_GetPower_Public_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 740706, XrefRangeEnd = 740707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetPower(float gearLevel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &gearLevel;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantPower.NativeMethodInfoPtr_GetPower_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 740709, RefRangeEnd = 740712, XrefRangeStart = 740707, XrefRangeEnd = 740709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetHuntProficiency()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantPower.NativeMethodInfoPtr_GetHuntProficiency_Public_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 740712, XrefRangeEnd = 740714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetHuntProficiency(float gearLevel, float profficiency)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &gearLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &profficiency;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantPower.NativeMethodInfoPtr_GetHuntProficiency_Public_Static_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 740714, RefRangeEnd = 740717, XrefRangeStart = 740714, XrefRangeEnd = 740714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetLootFactor(bool rawValue = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &rawValue;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantPower.NativeMethodInfoPtr_GetLootFactor_Public_Single_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 740717, RefRangeEnd = 740719, XrefRangeStart = 740717, XrefRangeEnd = 740717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetHealthBonusFactor()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantPower.NativeMethodInfoPtr_GetHealthBonusFactor_Public_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 740717, RefRangeEnd = 740719, XrefRangeStart = 740717, XrefRangeEnd = 740719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetDamageBonusFactor()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantPower.NativeMethodInfoPtr_GetDamageBonusFactor_Public_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ServantPower()
    {
      Il2CppClassPointerStore<ServantPower>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ServantPower));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantPower>.NativeClassPtr);
      ServantPower.NativeFieldInfoPtr_GearLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantPower>.NativeClassPtr, nameof (GearLevel));
      ServantPower.NativeFieldInfoPtr_Profficiency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantPower>.NativeClassPtr, nameof (Profficiency));
      ServantPower.NativeFieldInfoPtr_Power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantPower>.NativeClassPtr, nameof (Power));
      ServantPower.NativeMethodInfoPtr_GetPower_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantPower>.NativeClassPtr, 100665352);
      ServantPower.NativeMethodInfoPtr_GetPower_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantPower>.NativeClassPtr, 100665353);
      ServantPower.NativeMethodInfoPtr_GetHuntProficiency_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantPower>.NativeClassPtr, 100665354);
      ServantPower.NativeMethodInfoPtr_GetHuntProficiency_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantPower>.NativeClassPtr, 100665355);
      ServantPower.NativeMethodInfoPtr_GetLootFactor_Public_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantPower>.NativeClassPtr, 100665356);
      ServantPower.NativeMethodInfoPtr_GetHealthBonusFactor_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantPower>.NativeClassPtr, 100665357);
      ServantPower.NativeMethodInfoPtr_GetDamageBonusFactor_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantPower>.NativeClassPtr, 100665358);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantPower>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
