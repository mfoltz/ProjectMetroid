// Decompiled with JetBrains decompiler
// Type: ProjectM.ServantConversionHelper
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public static class ServantConversionHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MAXPOWER;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetServantMaxHealth_Public_Static_Single_Single_byref_ServantPowerData_byref_CurveCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetServantDamage_Public_Static_Single_Single_byref_ServantPowerData_byref_CurveCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPowerFromGear_Public_Static_Int32_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHuntProficiency_Public_Static_Int32_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomizedConvertedStats_Public_Static_Void_Single_Random_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 726923, RefRangeEnd = 726925, XrefRangeStart = 726921, XrefRangeEnd = 726923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetServantMaxHealth(
      float totalPower,
      [In] ref ServantPowerData powerData,
      [In] ref CurveCollection curveCollection)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &totalPower;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref powerData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref curveCollection;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantConversionHelper.NativeMethodInfoPtr_GetServantMaxHealth_Public_Static_Single_Single_byref_ServantPowerData_byref_CurveCollection_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 726923, RefRangeEnd = 726925, XrefRangeStart = 726923, XrefRangeEnd = 726925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetServantDamage(
      float totalPower,
      [In] ref ServantPowerData powerData,
      [In] ref CurveCollection curveCollection)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &totalPower;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref powerData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref curveCollection;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantConversionHelper.NativeMethodInfoPtr_GetServantDamage_Public_Static_Single_Single_byref_ServantPowerData_byref_CurveCollection_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726925, XrefRangeEnd = 726926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetPowerFromGear(float gearLevel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &gearLevel;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantConversionHelper.NativeMethodInfoPtr_GetPowerFromGear_Public_Static_Int32_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726926, XrefRangeEnd = 726928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetHuntProficiency(float gearLevel, float huntProficiency)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &gearLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &huntProficiency;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantConversionHelper.NativeMethodInfoPtr_GetHuntProficiency_Public_Static_Int32_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 726936, RefRangeEnd = 726938, XrefRangeStart = 726928, XrefRangeEnd = 726936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetRandomizedConvertedStats(
      float bloodQuality,
      Unity.Mathematics.Random randomHelper,
      out int lowPower,
      out int highPower,
      out int lowProficiency,
      out int highProficeny,
      out int randomizePower,
      out int randomizeProficiency)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &bloodQuality;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &randomHelper;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref lowPower;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref highPower;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref lowProficiency;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref highProficeny;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref randomizePower;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref randomizeProficiency;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantConversionHelper.NativeMethodInfoPtr_GetRandomizedConvertedStats_Public_Static_Void_Single_Random_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServantConversionHelper()
    {
      Il2CppClassPointerStore<ServantConversionHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ServantConversionHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantConversionHelper>.NativeClassPtr);
      ServantConversionHelper.NativeFieldInfoPtr_MAXPOWER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantConversionHelper>.NativeClassPtr, nameof (MAXPOWER));
      ServantConversionHelper.NativeMethodInfoPtr_GetServantMaxHealth_Public_Static_Single_Single_byref_ServantPowerData_byref_CurveCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantConversionHelper>.NativeClassPtr, 100664278);
      ServantConversionHelper.NativeMethodInfoPtr_GetServantDamage_Public_Static_Single_Single_byref_ServantPowerData_byref_CurveCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantConversionHelper>.NativeClassPtr, 100664279);
      ServantConversionHelper.NativeMethodInfoPtr_GetPowerFromGear_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantConversionHelper>.NativeClassPtr, 100664280);
      ServantConversionHelper.NativeMethodInfoPtr_GetHuntProficiency_Public_Static_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantConversionHelper>.NativeClassPtr, 100664281);
      ServantConversionHelper.NativeMethodInfoPtr_GetRandomizedConvertedStats_Public_Static_Void_Single_Random_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantConversionHelper>.NativeClassPtr, 100664282);
    }

    public ServantConversionHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe float MAXPOWER
    {
      get
      {
        float maxpower;
        IL2CPP.il2cpp_field_static_get_value(ServantConversionHelper.NativeFieldInfoPtr_MAXPOWER, (void*) &maxpower);
        return maxpower;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ServantConversionHelper.NativeFieldInfoPtr_MAXPOWER, (void*) &value);
      }
    }
  }
}
