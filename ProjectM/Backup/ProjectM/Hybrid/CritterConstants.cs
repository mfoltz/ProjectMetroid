// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.CritterConstants
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Hybrid
{
  public static class CritterConstants : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_bool_escape;
    private static readonly System.IntPtr NativeFieldInfoPtr_float_additiveTurn;
    private static readonly System.IntPtr NativeFieldInfoPtr_float_idleSpeedMultiplier;
    private static readonly System.IntPtr NativeFieldInfoPtr_float_onAggroSpeedMultiplier;
    private static readonly System.IntPtr NativeFieldInfoPtr_float_runSpeedMultiplier;

    static CritterConstants()
    {
      Il2CppClassPointerStore<CritterConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Hybrid", nameof (CritterConstants));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CritterConstants>.NativeClassPtr);
      CritterConstants.NativeFieldInfoPtr_bool_escape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterConstants>.NativeClassPtr, nameof (bool_escape));
      CritterConstants.NativeFieldInfoPtr_float_additiveTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterConstants>.NativeClassPtr, nameof (float_additiveTurn));
      CritterConstants.NativeFieldInfoPtr_float_idleSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterConstants>.NativeClassPtr, nameof (float_idleSpeedMultiplier));
      CritterConstants.NativeFieldInfoPtr_float_onAggroSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterConstants>.NativeClassPtr, nameof (float_onAggroSpeedMultiplier));
      CritterConstants.NativeFieldInfoPtr_float_runSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterConstants>.NativeClassPtr, nameof (float_runSpeedMultiplier));
    }

    public CritterConstants(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int bool_escape
    {
      get
      {
        int boolEscape;
        IL2CPP.il2cpp_field_static_get_value(CritterConstants.NativeFieldInfoPtr_bool_escape, (void*) &boolEscape);
        return boolEscape;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CritterConstants.NativeFieldInfoPtr_bool_escape, (void*) &value);
      }
    }

    public static unsafe int float_additiveTurn
    {
      get
      {
        int floatAdditiveTurn;
        IL2CPP.il2cpp_field_static_get_value(CritterConstants.NativeFieldInfoPtr_float_additiveTurn, (void*) &floatAdditiveTurn);
        return floatAdditiveTurn;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CritterConstants.NativeFieldInfoPtr_float_additiveTurn, (void*) &value);
      }
    }

    public static unsafe int float_idleSpeedMultiplier
    {
      get
      {
        int idleSpeedMultiplier;
        IL2CPP.il2cpp_field_static_get_value(CritterConstants.NativeFieldInfoPtr_float_idleSpeedMultiplier, (void*) &idleSpeedMultiplier);
        return idleSpeedMultiplier;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CritterConstants.NativeFieldInfoPtr_float_idleSpeedMultiplier, (void*) &value);
      }
    }

    public static unsafe int float_onAggroSpeedMultiplier
    {
      get
      {
        int aggroSpeedMultiplier;
        IL2CPP.il2cpp_field_static_get_value(CritterConstants.NativeFieldInfoPtr_float_onAggroSpeedMultiplier, (void*) &aggroSpeedMultiplier);
        return aggroSpeedMultiplier;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CritterConstants.NativeFieldInfoPtr_float_onAggroSpeedMultiplier, (void*) &value);
      }
    }

    public static unsafe int float_runSpeedMultiplier
    {
      get
      {
        int runSpeedMultiplier;
        IL2CPP.il2cpp_field_static_get_value(CritterConstants.NativeFieldInfoPtr_float_runSpeedMultiplier, (void*) &runSpeedMultiplier);
        return runSpeedMultiplier;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CritterConstants.NativeFieldInfoPtr_float_runSpeedMultiplier, (void*) &value);
      }
    }
  }
}
